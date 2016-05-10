using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Synless_Sprite_Editor
{
    public partial class Form1 : Form
    {

        Bitmap bmp;
        Color cColor = Color.Black;
        Color mColor = Color.Black;
        string name;
        string size;
        int scale = 10;
        bool picture_clickable = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            // WILL BREAK ANYWAY
            resetControl();
            while(true)
            {
                // USE AN OPENFILEDIALOG WITH FILTER TO OPEN A BMP FILE
                using (OpenFileDialog dlg = new OpenFileDialog())
                {
                    dlg.Title = "Open Image";
                    dlg.Filter = "bmp files (*.bmp)|*.bmp";
                    
                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        bmp = new Bitmap(dlg.FileName);

                        // TEST IF THE FILE HAS AN ACCEPTABLE SIZE, DISABLE THE EDITING IF NOT
                        if (bmp.Width * bmp.Height > 20000)
                        {
                            richTextBox1.Text = "IMAGE TO BIG";
                            picture_clickable = false;
                            break;
                        }
                        picture_clickable = true;

                        // GET THE NAME OF THE BROWED FILE
                        string[] names = dlg.FileName.Split('.')[0].Split('\\');
                        name = names[names.Length - 1];

                        scale = (int)(pictureBox1.Width / bmp.Width);
                        // CREATE A BIGGER IMAGE TO VIEW IT CLEARLY
                        Bitmap tenScaledImage = new Bitmap(bmp.Width * scale, bmp.Height * scale);
                        using (Graphics gr = Graphics.FromImage(tenScaledImage))
                        {   // NEEDED TO AVOID THE BLURING EFFECT OF SCALING
                            // CREATE SHIFTING ERROR SOLVED BY A SLITH SHIFTING AS DESCRIBED BELLOW
                            gr.InterpolationMode = InterpolationMode.NearestNeighbor;
                            gr.DrawImage(bmp, new Rectangle(0, 0, bmp.Width * scale, bmp.Height * scale));
                        }
                        // FILL THE MAIN PICTUREBOX WITH THE BIGGER IMAGE
                        pictureBox1.Width = tenScaledImage.Width;
                        pictureBox1.Height = tenScaledImage.Height;
                        pictureBox1.Image = new Bitmap(tenScaledImage);

                        int red = 0;
                        int green = 0;
                        int blue = 0;
                        int color = 0;

                        cColor = Color.FromArgb(0, 0, 0);
                        richTextBox1.Text = "";

                        // GO THROUGH THE IMAGE
                        size = (bmp.Height * bmp.Width).ToString();
                        richTextBox1.Text += "const uint16_t Ox" + name + "[" + size + "] = \n{";
                        for (int y = 0; y < bmp.Height; y++)
                        {
                            richTextBox1.Text += "\n\t";
                            for (int x = 0; x < bmp.Width; x++)
                            {
                                // GET R/G/B OF THE CURRENT PIXEL
                                red = bmp.GetPixel(x, y).R;
                                green = bmp.GetPixel(x, y).G;
                                blue = bmp.GetPixel(x, y).B;

                                // FROM 24BIT TO 16BIT FORMAT
                                color += (red >> 3) << 11;
                                color += (green >> 2) << 5;
                                color += (blue >> 3);
                                richTextBox1.Text += "0x";
                                // DISPLAY "color" IN HEX
                                richTextBox1.Text += color.ToString("X4");

                                if (x != bmp.Width - 1 || y != bmp.Height - 1)
                                {
                                    richTextBox1.Text += " , ";
                                }

                                red = 0;
                                green = 0;
                                blue = 0;
                                color = 0;
                            }

                        }
                        richTextBox1.Text += "\n};";
                    }
                    richTextBox1.Text += "\n\nconst Sprite s_Ox" + name + " = {" + bmp.Width + "," + bmp.Height + "," + name + "};";
                }
                break;
            }
        }
        // BECAUSE THE PROGRAM STILL HOLD THE FILE, AN ERROR OCCUR IF THE FILE IS SAVED WITH THE SAME NAME
        // HAVEN'T TRIED TO SOLVE IT, AS IT OFFER A NON ERASING SECURITY IF PROBLEMS HAPPEN AND YOU WANT THE ORIGINAL FILE BACK
        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog dialog = new SaveFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    dialog.Title = "Open Image";
                    dialog.Filter = "bmp files (*.bmp)|*.bmp";
                    bmp.Save(dialog.FileName);
                }
            }
            catch
            {
                MessageBox.Show("Use a different name than the source file.");
            }
        }        

        private void useBtn_Click(object sender, EventArgs e)
        {
            mColor = cColor;
            updateModdedColor();
            textBoxMod.Text = textBoxCurrent.Text;
            trackBarRed.Enabled = trackBarBlue.Enabled = trackBarGreen.Enabled = true;
            labelRed24.Text = mColor.R.ToString();
            labelGreen24.Text = mColor.G.ToString();
            labelBlue24.Text = mColor.B.ToString();
            trackBarRed.Value = mColor.R >> 3;
            trackBarGreen.Value = mColor.G >> 2;
            trackBarBlue.Value = mColor.B >> 3;
            labelRed16.Text = trackBarRed.Value.ToString();
            labelGreen16.Text = trackBarGreen.Value.ToString();
            labelBlue16.Text = trackBarBlue.Value.ToString();
            labelRed24.Text = (trackBarRed.Value << 3).ToString();
            labelGreen24.Text = (trackBarGreen.Value << 2).ToString();
            labelBlue24.Text = (trackBarBlue.Value << 3).ToString();
            replaceBtn.Enabled = true;
        }
        private void replaceBtn_Click(object sender, EventArgs e)
        {
            int red = 0;
            int green = 0;
            int blue = 0;
            int color = 0;

            Color oldColor = Color.FromArgb(0, 0, 0);

            richTextBox1.Text = "const uint16_t Ox" + name + "[" + size + "] = \n{";

            for (int y = 0; y < bmp.Height; y++)
            {
                richTextBox1.Text += "\n\t";
                for (int x = 0; x < bmp.Width; x++)
                {
                    red = bmp.GetPixel(x, y).R;
                    green = bmp.GetPixel(x, y).G;
                    blue = bmp.GetPixel(x, y).B;

                    Int32 col = (red << 16) + (green << 8) + blue;
                    oldColor = Color.FromArgb(col);
                    if (oldColor.R == cColor.R && oldColor.G == cColor.G && oldColor.B == cColor.B)
                    {
                        bmp.SetPixel(x, y, mColor);
                    }

                    red = bmp.GetPixel(x, y).R;
                    green = bmp.GetPixel(x, y).G;
                    blue = bmp.GetPixel(x, y).B;

                    // AGAIN, 24BIT TO 16BIT
                    red = red >> 3;
                    green = green >> 2;
                    blue = blue >> 3;
                    color += red << 11;
                    color += green << 5;
                    color += blue;

                    richTextBox1.Text += "0x";
                    // DISPLAY "color" IN HEX
                    richTextBox1.Text += color.ToString("X4");

                    if (x != bmp.Width - 1 || y != bmp.Height - 1)
                    {
                        richTextBox1.Text += " , ";
                    }

                    red = 0;
                    green = 0;
                    blue = 0;
                    color = 0;
                }
            }
            richTextBox1.Text += "\n};";
            richTextBox1.Text += "\n\nconst Sprite s_Ox" + name + " = {" + bmp.Width + "," + bmp.Height + "," + name + "};";
            Bitmap newImage = new Bitmap(bmp.Width * scale, bmp.Height * scale);
            using (Graphics gr = Graphics.FromImage(newImage))
            {
                gr.SmoothingMode = SmoothingMode.Default;
                gr.InterpolationMode = InterpolationMode.NearestNeighbor;
                gr.PixelOffsetMode = PixelOffsetMode.Default;
                gr.DrawImage(bmp, new Rectangle(0, 0, bmp.Width * scale, bmp.Height * scale));
            }
            pictureBox1.Image = new Bitmap(newImage);
        }

        // GET THE CLICKED PIXEL AND PAST HIS COLOR ONTO TO "USE" SECTION
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (picture_clickable)
            {
                Bitmap bmp2 = (Bitmap)pictureBox1.Image;
                MouseEventArgs me = (MouseEventArgs)e;
                Point coordinates = me.Location;
                // SHIFTING ERROR DUE TO SCALING            
                coordinates.X += 5;
                coordinates.Y += 5;
                int x = (coordinates.X - coordinates.X % scale);
                int y = (coordinates.Y - coordinates.Y % scale);
                int red = 0;
                int green = 0;
                int blue = 0;
                int color = 0;
                red = bmp2.GetPixel(x, y).R;
                green = bmp2.GetPixel(x, y).G;
                blue = bmp2.GetPixel(x, y).B;
                // AGAIN, 24BIT TO 16BIT CONVERSION
                color += (red >> 3) << 11;
                color += (green >> 2) << 5;
                color += (blue >> 3);
                textBoxCurrent.Text = color.ToString("X4");
                Bitmap currentBmp = new Bitmap(64, 64);
                cColor = Color.FromArgb(0, 0, 0);
                // FILL THE "USE" PICTUREBOX WITH A 64x64 IMAGE COLORED WITH THE CLICKED PIXEL
                for (int x1 = 0; x1 < 64; x1++)
                {
                    for (int y1 = 0; y1 < 64; y1++)
                    {
                        cColor = Color.FromArgb(red, green, blue);
                        currentBmp.SetPixel(x1, y1, cColor);
                    }
                }
                pictureBoxCurrent.Image = currentBmp;
                // NOW THAT THE "USE SECTION IS FILLED, ENABLE IT   
                useBtn.Enabled = true;
            }
        }
        // CHANGE THE VALUE IF ONE OF THE TRACKBAR MOVE
        private void trackBar_Scroll(object sender, EventArgs e)
        {
            int red = Math.Min(trackBarRed.Value, 31);
            int green = Math.Min(trackBarGreen.Value, 63);
            int blue = Math.Min(trackBarBlue.Value, 31);
            labelRed16.Text = red.ToString();
            labelGreen16.Text = green.ToString();
            labelBlue16.Text = blue.ToString();
            labelRed24.Text = (red << 3).ToString();
            labelGreen24.Text = (green << 2).ToString();
            labelBlue24.Text = (blue << 3).ToString();
            int color = (trackBarRed.Value << 11) + (green << 5) + blue;
            textBoxMod.Text = color.ToString("X4");
            red = red << 3;
            green = green << 2;
            blue = blue << 3;
            mColor = Color.FromArgb(red, green, blue);
            updateModdedColor();

        }
        private void updateModdedColor()
        {
            Bitmap modded = new Bitmap(64, 64);
            for (int x1 = 0; x1 < 64; x1++)
            {
                for (int y1 = 0; y1 < 64; y1++)
                {
                    modded.SetPixel(x1, y1, mColor);
                }
            }
            pictureBoxMod.Image = modded;
        }     
        private void resetControl()
        {
            useBtn.Enabled = false;
            replaceBtn.Enabled = false;
            trackBarRed.Value = 0;
            trackBarGreen.Value = 0;
            trackBarBlue.Value = 0;
            trackBarRed.Enabled = false;
            trackBarGreen.Enabled = false;
            trackBarBlue.Enabled = false;
        }
    }
}

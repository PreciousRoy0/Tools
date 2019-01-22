using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.IO;
using System.Xml;

namespace BitmapFontMaker
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        List<Letter> Letters = new List<Letter>();
        Font drawfont;
        Brush drawbrush;

        private void Form1_Load(object sender, EventArgs e)
        {
            FontFamily[] fontFamilies;

            InstalledFontCollection installedFontCollection = new InstalledFontCollection();

            // Get the array of FontFamily objects.
            fontFamilies = installedFontCollection.Families;

            foreach (FontFamily font in fontFamilies)
            {
                FontComboBox.Items.Add(font.Name);
            }

            FontComboBox.Text = "Arial";
            ImagePanle.Width = int.Parse(WidthNumericUpDown.Text);
            ImagePanle.Height = int.Parse(HeightNumericUpDown.Text);

            drawfont = new Font(FontComboBox.Text, (float)FontSizeHeightNumericUpDown.Value);
            drawbrush = new SolidBrush(Color.Black);

            
        }

        private void toolStripComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void WidthNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ImagePanle.Width = int.Parse(WidthNumericUpDown.Text);
            GenerateLetters();
        }

        private void HeightNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            ImagePanle.Height = int.Parse(HeightNumericUpDown.Text);
            GenerateLetters();
        }

        private void ImagePanle_Paint(object sender, PaintEventArgs e)
        {
            foreach (Letter letter in Letters)
            {
                e.Graphics.DrawString(letter.letter.ToString(), drawfont, drawbrush, letter.rectangle);
            }
        }

        private void GenerateLetters()
        {
            Letters.Clear();

            Bitmap blank = new Bitmap(ImagePanle.Width, ImagePanle.Height);
            Graphics graphics = Graphics.FromImage(blank);


            float x = 0;
            float y = 0;
            for (int c = 32; c < 126; c++)
            {
                Letter l = new Letter();
                l.letter = (char)c;

                RectangleF rect = new RectangleF();
                char d = ((char)c);
                SizeF size = graphics.MeasureString(((char)c).ToString(), drawfont);

                if (x + size.Width > ImagePanle.Width)
                {
                    x = 0;
                    y += size.Height;
                }

                rect.X = x;
                rect.Y = y;
                rect.Width = size.Width;
                rect.Height = size.Height;

                x += size.Width;

                l.rectangle = rect;
                Letters.Add(l);
            }

            ImagePanle.Invalidate();
        }

        private void FontSizeHeightNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            drawfont = new Font(FontComboBox.Text, (float)FontSizeHeightNumericUpDown.Value);
            GenerateLetters();
        }

        private void FontComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            drawfont = new Font(FontComboBox.Text, (float)FontSizeHeightNumericUpDown.Value);
            GenerateLetters();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "png files (*.png)|*.png";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Bitmap blank = new Bitmap(ImagePanle.Width, ImagePanle.Height);

                blank.MakeTransparent();

                Graphics graphics = Graphics.FromImage(blank);

                foreach (Letter letter in Letters)
                {
                    graphics.DrawString(letter.letter.ToString(), drawfont, drawbrush, letter.rectangle);
                }

                blank.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);

                string xml = Directory.GetParent(saveFileDialog1.FileName) + "\\" + Path.GetFileNameWithoutExtension(saveFileDialog1.FileName) + ".xml";

                XmlWriterSettings settings = new XmlWriterSettings();
                settings.WriteEndDocumentOnClose = true;
                settings.Indent = true;
                
                XmlWriter writer = XmlWriter.Create(xml, settings);
                writer.WriteStartElement("BitmapFont");
                writer.WriteAttributeString("SpriteSheet", Path.GetFileName(saveFileDialog1.FileName));
                writer.WriteAttributeString("FontSize", FontSizeHeightNumericUpDown.Value.ToString());

                foreach (Letter letter in Letters)
                {
                    writer.WriteStartElement("Letter");
                    writer.WriteAttributeString("Char", letter.letter.ToString());
                    writer.WriteAttributeString("X", letter.rectangle.X.ToString());
                    writer.WriteAttributeString("Y", letter.rectangle.Y.ToString());
                    writer.WriteAttributeString("Width", letter.rectangle.Width.ToString());
                    writer.WriteAttributeString("Height", letter.rectangle.Height.ToString());
                    writer.WriteEndElement();
                    
                }
                writer.WriteEndElement();
                writer.Close();
            }
        }

        private void AboutButton_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.ShowDialog();
        }
    }
    public class Letter
    {
        public RectangleF rectangle;
        public char letter;
    }

}

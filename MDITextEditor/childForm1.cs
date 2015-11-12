using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDITextEditor
{
    public partial class childForm1 : Form
    {
        public childForm1(string title)
        {
            InitializeComponent();
            Text = title;
        }

        public void ChangeTextColor(Color color)
        {
            this.childRichTextBox.SelectionColor = color;
        }

        public void ChangeTextSize(int size)
        {
            //this.childRichTextBox.SelectionFont.SizeInPoints= size;
            System.Drawing.Font currentFont = childRichTextBox.SelectionFont;

            if ( size==10)
            {
                childRichTextBox.SelectionFont = new Font(currentFont.FontFamily.ToString(), 10, currentFont.Style);
            }
            if (size == 12)
            {
                childRichTextBox.SelectionFont = new Font(currentFont.FontFamily.ToString(), 12, currentFont.Style);
            }
            if (size == 14)
            {
                childRichTextBox.SelectionFont = new Font(currentFont.FontFamily.ToString(), 14, currentFont.Style);
            }
            if (size == 16)
            {
                childRichTextBox.SelectionFont = new Font(currentFont.FontFamily.ToString(), 16, currentFont.Style);
            }
        }

        public void ChangeTextFont(int fontNum)
        {
            System.Drawing.Font currentFont = childRichTextBox.SelectionFont;
            
            if (fontNum == 1)
            {
                childRichTextBox.SelectionFont = new Font(((fontFamilies)1).ToString(), currentFont.Size, currentFont.Style);
            }
            if (fontNum == 2)
            {
                childRichTextBox.SelectionFont = new Font("Bauhaus 93", currentFont.Size, currentFont.Style);
            }
            if (fontNum == 3)
            {
                childRichTextBox.SelectionFont = new Font(((fontFamilies)3).ToString(), currentFont.Size, currentFont.Style);
            }
            if (fontNum == 4)
            {
                childRichTextBox.SelectionFont = new Font(((fontFamilies)4).ToString(), currentFont.Size, currentFont.Style);
            }
            if (fontNum == 5)
            {
                childRichTextBox.SelectionFont = new Font(((fontFamilies)5).ToString(), currentFont.Size, currentFont.Style);
            }
            if (fontNum == 6)
            {
                childRichTextBox.SelectionFont = new Font(((fontFamilies)6).ToString(), currentFont.Size, currentFont.Style);
            }
            if (fontNum == 7)
            {
                childRichTextBox.SelectionFont = new Font("Times New Roman".ToString(), currentFont.Size, currentFont.Style);
            }
        }

        enum fontFamilies
        {
            Baskerville =1,
            [Description("Bauhaus 93")]
            Bauhaus,
            Courier,
            Futura,
            Garamond,
            Helvetica,
            [Description("Times New Roman")]
            Times
        }
    }
}

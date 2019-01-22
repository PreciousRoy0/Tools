using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace BitmapFontMaker
{
    [ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.ToolStrip)]
    public class ToolStripNumericUpDown: ToolStripControlHost
    {
        public ToolStripNumericUpDown()
            : base(new NumericUpDown())
        {

        }

        public decimal Value 
        { 
            get
            {
                return ((NumericUpDown)Control).Value;
            }
            set
            {
                ((NumericUpDown)Control).Value = value;
            }
        }

        public decimal Minimum
        {
            get
            {
                return ((NumericUpDown)Control).Minimum;
            }
            set
            {
                ((NumericUpDown)Control).Minimum = value;
            }
        }

        public decimal Maximum
        {
            get
            {
                return ((NumericUpDown)Control).Maximum;
            }
            set
            {
                ((NumericUpDown)Control).Maximum = value;
            }
        }

        protected override void OnSubscribeControlEvents(Control control)
        {
            base.OnSubscribeControlEvents(control);
            ((NumericUpDown)control).ValueChanged += new EventHandler(OnValueChanged);
        }

        protected override void OnUnsubscribeControlEvents(Control control)
        {
            base.OnUnsubscribeControlEvents(control);
            ((NumericUpDown)control).ValueChanged -= new EventHandler(OnValueChanged);
        }

        public event EventHandler ValueChanged;

        public Control NumericUpDownControl
        {
            get { return Control as NumericUpDown; }
        }

        public void OnValueChanged(object sender, EventArgs e)
        {
            if (ValueChanged != null)
            {
                ValueChanged(this, e);
            }
        }
    }
}

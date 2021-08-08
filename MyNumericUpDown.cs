using System.Windows.Forms;

namespace ExamplePacketPlugin
{
    public class MyNumericUpDown : NumericUpDown
    {
        protected override void UpdateEditText()
        {
            this.Text = this.Value.ToString().PadLeft(2, '0');
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Interactivity;

namespace L054
{
    public class GrowTextBehavior : Behavior<TextBlock>
    {
        public int GrowBySize { set; get; }

        protected override void OnAttached()
        {
            base.OnAttached();
            AssociatedObject.MouseEnter += AssociatedObject_MouseEnter;
            AssociatedObject.MouseLeave += AssociatedObject_MouseLeave;
        }

        private void AssociatedObject_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            //throw new NotImplementedException();
            AssociatedObject.FontSize -= GrowBySize;
        }

        private void AssociatedObject_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            //throw new NotImplementedException();
            AssociatedObject.FontSize += GrowBySize;
        }

        protected override void OnDetaching()
        {
            base.OnDetaching();
            AssociatedObject.MouseEnter -= AssociatedObject_MouseEnter;
            AssociatedObject.MouseLeave -= AssociatedObject_MouseLeave;
        }
    }
    public class GrowTextBehavior1 : Behavior<Label>
    {
        public int GrowBySize { set; get; }

        protected override void OnAttached()
        {
            base.OnAttached();
            AssociatedObject.MouseEnter += AssociatedObject_MouseEnter;
            AssociatedObject.MouseLeave += AssociatedObject_MouseLeave;
        }

        private void AssociatedObject_MouseLeave(object sender, System.Windows.Input.MouseEventArgs e)
        {
            //throw new NotImplementedException();
            AssociatedObject.FontSize -= GrowBySize;
        }

        private void AssociatedObject_MouseEnter(object sender, System.Windows.Input.MouseEventArgs e)
        {
            //throw new NotImplementedException();
            AssociatedObject.FontSize += GrowBySize;
        }

        protected override void OnDetaching()
        {
            base.OnDetaching();
            AssociatedObject.MouseEnter -= AssociatedObject_MouseEnter;
            AssociatedObject.MouseLeave -= AssociatedObject_MouseLeave;
        }
    }
}

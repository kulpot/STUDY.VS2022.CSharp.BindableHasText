using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BindableHasText
{
    class ExTextBox : TextBox, INotifyPropertyChanged
    {
        /// <summary>
        /// Gets whether the control contains text
        /// </summary>
        [Browsable(false)]
        public bool HasText
        {
            get { return TextLength > 0; }
        }

        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            OnPropertyChanged("HasText");
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                var args = new PropertyChangedEventArgs(propertyName);
                PropertyChanged(this, args);
            }
        }
    }
}

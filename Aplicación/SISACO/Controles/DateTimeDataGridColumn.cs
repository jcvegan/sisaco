using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.ComponentModel;

namespace SISACO.Controles {
    public class DateTimeDataGridViewColumn : DataGridViewColumn {

        #region - Campos -

        private DateTime _selectedValue;

        #endregion

        #region - Constructor -

        public DateTimeDataGridViewColumn()
            : base(new DateTimeDataGridViewCell()) {

        }

        #endregion
        
        #region - Propiedades -

        public DateTime SelectedValue {
            get { return _selectedValue; }
            set { _selectedValue = value; }
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override DataGridViewCell CellTemplate {
            get {
                return base.CellTemplate;
            }
            set {
                DateTimeDataGridViewCell datetimeDataGridViewCell = value as DateTimeDataGridViewCell;
                if (value != null && datetimeDataGridViewCell == null) {
                    throw new InvalidCastException();
                }
                base.CellTemplate = value;
            }
        }

        #endregion

    }
}

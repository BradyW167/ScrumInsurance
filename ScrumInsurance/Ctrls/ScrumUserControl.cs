using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Crmf;

namespace ScrumInsurance
{
    public class ScrumUserControl : UserControl
    {
        protected Session Session { get; set; }

        protected TableLayoutPanel PnlMain { get; set; }

        public ScrumUserControl() {}

        // When called without an input control to load
        // Load this control into the parent panel
        public void loadControl() { loadControl(this, 0, 0); }

        // Creates a new row in the table and loads the dashboard
        public void loadDash()
        {
            // Initialize dashboard control if not already
            if (Session.CtrlDashboard == null) {
                Session.CtrlDashboard = new ctrlDashboard();
            }

            // Add another row to the table layout panel
            PnlMain.RowCount = 2;

            // Set the row to a fixed size of 50 pixels
            PnlMain.RowStyles[0] = new RowStyle(SizeType.Absolute, 50);

            // Load the dashboard control into first row
            loadControl(Session.CtrlDashboard, 0, 0);
        }

        // Removes the dashboard control and decreases row count
        public void removeDash()
        {
            // If the dashboard control exists...
            if (Session.CtrlDashboard != null)
            {
                // Remove the dashboard control
                removeControl(Session.CtrlDashboard);
            }
            else
            {
                return;
            }
        }

        // Load input control into parent table layout panel at input column and row
        public void loadControl(ScrumUserControl newCtrl, int columnIndex, int rowIndex)
        {
            // Return if main panel does not exist
            if (PnlMain == null) { return; }

            // Return if cell already has a control within
            if (PnlMain.GetControlFromPosition(columnIndex, rowIndex ) != null) { return; }
            
            // Update ScrumUserControl attributes for new control
            newCtrl.PnlMain = PnlMain;
            newCtrl.Session = Session;
            
            // Update style attributes for new control
            newCtrl.Dock = DockStyle.Fill;
            newCtrl.AutoSize = false;
            newCtrl.Anchor = AnchorStyles.None;
            
            PnlMain.Controls.Add(newCtrl, columnIndex, rowIndex);

            // Center the control within its row
            CenterUserControl(newCtrl);
        }

        /*
         * Remove control by position in table
         * Defaults to first column and row
         */
        private void removeControl(ScrumUserControl control)
        {
            // Get the position of input control in the panel
            int columnIndex = PnlMain.GetRow(control);
            int rowIndex = PnlMain.GetRow(control);

            // Stores the control for each loop
            Control loopCtrl = null;

            // Loop through all the row indices after input control
            for (int row = rowIndex + 1; row < PnlMain.RowCount; row++)
            {
                // Store the control 
                loopCtrl = PnlMain.GetControlFromPosition(0, row);

                // If there is a control in this row
                if (loopCtrl != null)
                {
                    // Shift the loopCtrl down 1 row
                    PnlMain.SetRow(loopCtrl, row - 1);
                }
            }

            // Remove the control and clean up resources allocated
            PnlMain.Controls.Remove(control);
            control.Dispose();

            // Delete a row from the table layout panel
            PnlMain.RowCount--;
        }

        // Deletes this user control in parent panel and loads a new input control
        public void swapControl(ScrumUserControl newControl)
        {
            // Get the position of this control in the panel
            int columnIndex = PnlMain.GetRow(this);
            int rowIndex = PnlMain.GetRow(this);

            // Remove this control
            removeControl(this);

            // Load the new control in this control's position
            loadControl(newControl, columnIndex, rowIndex);
        }

        // Function to center the UserControl inside the column
        public void CenterUserControl(ScrumUserControl control)
        {
            // Get the position of input control in the panel
            int columnIndex = PnlMain.GetRow(control);
            int rowIndex = PnlMain.GetRow(control);

            // Get the column width and row height
            int columnWidth = PnlMain.GetColumnWidths()[columnIndex];
            int rowHeight = PnlMain.GetRowHeights()[rowIndex];

            // Set the position dynamically
            control.Left = (columnWidth - control.Width) / 2;
            control.Top = (rowHeight - control.Height) / 2;
        }
    }
}

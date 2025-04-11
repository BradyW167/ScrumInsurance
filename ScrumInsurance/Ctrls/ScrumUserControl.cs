using System;
using System.Collections.Generic;
using System.ComponentModel;
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
        protected DatabaseController DBController { get; set; }
        protected TableLayoutPanel PnlMain { get; set; }

        public ScrumUserControl() {
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime)
            {
                return; // Prevent instantiation during design time
            }
        }

        // When called without an input control to load
        // Load this control into the parent panel
        public void loadControl() { loadControl(this, 0, 0); }

        // Creates a new row in the table and loads the dashboard
        public void loadCtrlDash()
        {
            // Initialize dashboard control if not already
            if (Session.CtrlDashboard == null) {
                Session.CtrlDashboard = new ctrlDashboard();

                // Load the dashboard control into first row
                loadControl(Session.CtrlDashboard, 0, 0);

                // Set the row to a fixed size of 50 pixels
                PnlMain.RowStyles[0] = new RowStyle(SizeType.Absolute, 50);
            }
        }

        // Loads a new control into the main control row
        public void loadCtrlMain(ScrumUserControl newCtrl)
        {
            // Set session object for main control to newCtrl
            Session.CtrlMain = newCtrl;

            // If the dashboard does not exist...
            if (Session.CtrlDashboard == null)
            {
                // Load the new main control into first row
                loadControl(Session.CtrlDashboard, 0, 0);
            }
            // Else dashboard does exist
            else
            {
                // Load the new main control into second row
                loadControl(Session.CtrlDashboard, 1, 0);
            }
        }

        // Removes the dashboard control and decreases row count
        public void removeDash()
        {
            // If the dashboard control exists...
            if (Session.CtrlDashboard != null)
            {
                // Remove the dashboard control
                removeControl(Session.CtrlDashboard);

                // Set dashboard property back to null after deletion
                Session.CtrlDashboard = null;

                PnlMain.RowStyles[0] = new RowStyle(SizeType.AutoSize);
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

            // If cell at input column and row already has a control within...
            if (PnlMain.GetControlFromPosition(columnIndex, rowIndex) != null) {
                // Add a row to the main panel
                PnlMain.RowCount++;

                // Stores the control for each loop
                Control loopCtrl = null;

                // Loop through all the row indices starting at last non-empty row
                // Must be done backwards to not copy the same row all the way down
                for (int row = PnlMain.RowCount - 2; row >= rowIndex; row--)
                {
                    // Store the control 
                    loopCtrl = PnlMain.GetControlFromPosition(0, row);

                    // If there is a control in this row
                    if (loopCtrl != null)
                    {
                        // Shift the loopCtrl down one row
                        PnlMain.SetRow(loopCtrl, row + 1);
                    }
                }
            }
            
            // Update ScrumUserControl attributes for new control
            newCtrl.PnlMain = PnlMain;
            newCtrl.DBController = DBController;
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
            // If multiple rows exist...
            if (PnlMain.RowCount > 1)
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

                // Delete a row from the table layout panel
                PnlMain.RowCount--;
            }

            // Remove the control and clean up resources allocated
            PnlMain.Controls.Remove(control);
            control.Dispose();
        }

        // Deletes this user control in parent panel and loads a new input control
        public void swapCtrlMain(ScrumUserControl newControl)
        {
            // Do not swap if new control is of the same type
            if (Session.CtrlMain.GetType() == newControl.GetType()) { return; }

            // Get the position of this control in the panel
            int columnIndex = PnlMain.GetColumn(Session.CtrlMain);
            int rowIndex = PnlMain.GetRow(Session.CtrlMain);

            // Remove the control and clean up resources allocated
            PnlMain.Controls.Remove(Session.CtrlMain);
            Session.CtrlMain.Dispose();

            // Load the new control into the main control's position
            loadControl(newControl, columnIndex, rowIndex);

            Session.CtrlMain = newControl;
        }

        // Function to center the UserControl inside the column
        public void CenterUserControl(ScrumUserControl control)
        {
            // Get the position of input control in the panel
            int columnIndex = PnlMain.GetColumn(control);
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

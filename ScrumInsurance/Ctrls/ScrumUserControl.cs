﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Org.BouncyCastle.Crmf;

namespace ScrumInsurance.Ctrls
{
    public class ScrumUserControl : UserControl
    {
        protected Session Session { get; set; }
        protected DatabaseController DBController { get; set; }
        protected TableLayoutPanel PnlMain { get; set; }
        protected Form FrmMain { get; set; }

        public ScrumUserControl() {}

        public ScrumUserControl(ScrumUserControl ctrl) {
            Session = ctrl.Session;
            DBController = ctrl.DBController;
            PnlMain = ctrl.PnlMain;
            FrmMain = ctrl.FrmMain;
        }

        // When called without an input control to load
        // Load this control into the parent panel
        public void LoadCtrl() { LoadCtrl(this, 0, 0); }

        // Creates a new row in the table and loads the dashboard
        public void LoadCtrlDash()
        {
            // Initialize dashboard control if not already
            if (Session.CtrlDashboard == null) {
                Session.CtrlDashboard = new ctrlDashboard(this);

                Session.CtrlDashboard.Dock = DockStyle.Fill;

                // Load the dashboard control into first row
                LoadCtrl(Session.CtrlDashboard, 0, 0);

                // Set the row to a fixed size of 40 pixels
                PnlMain.RowStyles[0].SizeType = SizeType.Absolute;
                PnlMain.RowStyles[0].Height = 40;

                FrmMain.Height += 40;
            }
        }

        public void LoadCtrlFooter()
        {
            // Initialize dashboard control if not already
            if (Session.CtrlFooter == null)
            {
                Session.CtrlFooter = new ctrlFooter(this);

                Session.CtrlFooter.Dock = DockStyle.Fill;


                // Load the dashboard control into third row
                LoadCtrl(Session.CtrlFooter, 0, 2);

                // Set the row to a fixed size of 40 pixels
                PnlMain.RowStyles[2].SizeType = SizeType.Absolute;
                PnlMain.RowStyles[2].Height = 40;

                FrmMain.Height += 40;
            }
        }

        // Loads a new control into the main control row
        public void LoadCtrlMain(ScrumUserControl newCtrl)
        {
            // Set session object for main control to newCtrl
            Session.CtrlMain = newCtrl;

            // Set the row to a fixed size of 40 pixels
            PnlMain.RowStyles[1].SizeType = SizeType.Percent;
            PnlMain.RowStyles[1].Height = 100;

            // Set main control to float in center
            newCtrl.Anchor = AnchorStyles.None;

            // If the dashboard does not exist...
            if (Session.CtrlDashboard == null)
            {
                // Load the new main control into first row
                LoadCtrl(Session.CtrlMain, 0, 0);
            }
            // Else dashboard does exist
            else
            {
                // Load the new main control into second row
                LoadCtrl(Session.CtrlMain, 1, 0);
            }
        }

        // Removes the dashboard control
        public void RemoveCtrlDash()
        {
            // If the dashboard control exists...
            if (Session.CtrlDashboard != null)
            {
                // Remove the dashboard control
                RemoveControl(Session.CtrlDashboard);

                // Set dashboard property back to null after deletion
                Session.CtrlDashboard = null;

                PnlMain.RowStyles[0].SizeType = SizeType.Percent;
                PnlMain.RowStyles[0].Height = 100;

                FrmMain.Height -= 40;
            }
            else
            {
                return;
            }
        }

        // Removes the footer control
        public void RemoveCtrlFooter()
        {
            // If the dashboard control exists...
            if (Session.CtrlFooter != null)
            {
                // Remove the dashboard control
                RemoveControl(Session.CtrlFooter);

                // Set dashboard property back to null after deletion
                Session.CtrlFooter = null;

                FrmMain.Height -= 40;
            }
            else
            {
                return;
            }
        }

        // Load input control into parent table layout panel at input column and row
        public void LoadCtrl(ScrumUserControl newCtrl, int columnIndex, int rowIndex)
        {

            // Return if main panel does not exist
            if (PnlMain == null) { return; }

            // If cell at input column and row already has a control within...
            if (PnlMain.GetControlFromPosition(columnIndex, rowIndex) != null) {
                // Add a row to the main panel
                PnlMain.RowCount++;

                // Stores the control for each loop
                Control loop_ctrl = null;

                // Loop through all the row indices starting at last non-empty row
                // Must be done backwards to not copy the same row all the way down
                for (int row = PnlMain.RowCount - 2; row >= rowIndex; row--)
                {
                    // Store the control 
                    loop_ctrl = PnlMain.GetControlFromPosition(0, row);

                    // If there is a control in this row
                    if (loop_ctrl != null)
                    {
                        // Shift the loopCtrl down one row
                        PnlMain.SetRow(loop_ctrl, row + 1);
                    }
                }
            }
            
            PnlMain.Controls.Add(newCtrl, columnIndex, rowIndex);

            // Center the control within its row
            // CenterCtrl(newCtrl);
        }

        /* 
         * Remove control by position in table
         * Defaults to first column and row
         */
        private void RemoveControl(ScrumUserControl control)
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
        public void SwapCtrlMain(ScrumUserControl newControl)   
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
            LoadCtrlMain(newControl);
        }

        // Function to center the UserControl inside the column
        public void CenterCtrl()
        {
            // Get the position of input control in the panel
            int columnIndex = PnlMain.GetColumn(this);
            int rowIndex = PnlMain.GetRow(this);

            // Get the column width and row height
            int columnWidth = PnlMain.GetColumnWidths()[columnIndex];
            int rowHeight = PnlMain.GetRowHeights()[rowIndex];

            // Set the position dynamically
            this.Left = (columnWidth - this.Width) / 2;
            this.Top = (rowHeight - this.Height) / 2;
        }

        // Resizes the main form to input width and height
        public void ResizeMainForm(int w, int h)
        {
            // These numbers account for the border that forms have by default
            FrmMain.Width = w + 16;
            FrmMain.Height = h + 39;
        }
    }
}

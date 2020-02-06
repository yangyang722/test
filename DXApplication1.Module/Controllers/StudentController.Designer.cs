namespace DXApplication1.Module.Controllers
{
    partial class StudentController
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();

            this.plantomanubill = new DevExpress.ExpressApp.Actions.PopupWindowShowAction(this.components);

            this.plantomanubill.AcceptButtonCaption = null;
            this.plantomanubill.CancelButtonCaption = null;
            this.plantomanubill.Caption = "休学";
            this.plantomanubill.Category = "Edit";
            this.plantomanubill.ConfirmationMessage = null;
            this.plantomanubill.Id = "plantomanubill";
            this.plantomanubill.ImageName = "Action_ModelDifferences_Create";
            this.plantomanubill.ToolTip = null;
            this.plantomanubill.CustomizePopupWindowParams += new DevExpress.ExpressApp.Actions.CustomizePopupWindowParamsEventHandler(this.plantomanubill_CustomizePopupWindowParams);
            this.plantomanubill.Execute += new DevExpress.ExpressApp.Actions.PopupWindowShowActionExecuteEventHandler(this.plantomanubill_Execute);

            this.Actions.Add(this.plantomanubill);
        }
        private DevExpress.ExpressApp.Actions.PopupWindowShowAction plantomanubill;

        #endregion
    }
}

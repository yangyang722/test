namespace DXApplication1.Module.Controllers
{
    partial class SaveAndCancelAction
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
            this.btnConvertBillbtnSave = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);
            this.btnConvertBillbtnCancel = new DevExpress.ExpressApp.Actions.SimpleAction(this.components);

            // 
            // btnConvertBillbtnSave
            // 
            this.btnConvertBillbtnSave.Caption = "保存";
            this.btnConvertBillbtnSave.Category = "PopupActions";
            this.btnConvertBillbtnSave.ConfirmationMessage = null;
            this.btnConvertBillbtnSave.Id = "btnConvertBillbtnSave";
            this.btnConvertBillbtnSave.TargetViewId = "Student_ListView_CheckBox";
            this.btnConvertBillbtnSave.ToolTip = null;
            // 
            // btnConvertBillbtnCancel
            // 
            this.btnConvertBillbtnCancel.Caption = "取消";
            this.btnConvertBillbtnCancel.Category = "PopupActions";
            this.btnConvertBillbtnCancel.ConfirmationMessage = null;
            this.btnConvertBillbtnCancel.Id = "btnConvertBillbtnCancel";
            this.btnConvertBillbtnCancel.TargetViewId = "Student_ListView_CheckBox";
            this.btnConvertBillbtnCancel.ToolTip = null;


            this.Actions.Add(this.btnConvertBillbtnSave);
            this.Actions.Add(this.btnConvertBillbtnCancel);
        }
        private DevExpress.ExpressApp.Actions.SimpleAction btnConvertBillbtnSave;
        private DevExpress.ExpressApp.Actions.SimpleAction btnConvertBillbtnCancel;
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.ExpressApp.Editors;
using DevExpress.ExpressApp.Layout;
using DevExpress.ExpressApp.Model.NodeGenerators;
using DevExpress.ExpressApp.SystemModule;
using DevExpress.ExpressApp.Templates;
using DevExpress.ExpressApp.Utils;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;

namespace DXApplication1.Module.Controllers
{
    public partial class SaveAndCancelAction : ViewController
    {
        public SimpleAction btnconvertbillsave;
        public SimpleAction btnconvertbillcancel;
        public SaveAndCancelAction()
        {
            InitializeComponent();
            btnconvertbillcancel = btnConvertBillbtnCancel;
            btnconvertbillsave = btnConvertBillbtnSave;
        }
        protected override void OnActivated()
        {
            base.OnActivated();
        }
        protected override void OnViewControlsCreated()
        {
            base.OnViewControlsCreated();
        }
        protected override void OnDeactivated()
        {
            base.OnDeactivated();
        }
    }
}

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
using DevExpress.ExpressApp.Web;
using DevExpress.ExpressApp.Win;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.Validation;
using DXApplication1.Module.BusinessObjects;

namespace DXApplication1.Module.Controllers
{
    public partial class StudentController : ViewController<ListView>
    {
        public StudentController()
        {
            InitializeComponent();
            this.TargetObjectType = typeof(Student);
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

        #region 生产计划转生产订单
        /// <summary>
        /// 计划转订单
        /// </summary>
        private void plantomanubill_CustomizePopupWindowParams(object sender, CustomizePopupWindowParamsEventArgs e)
        {
            if ((this.Application is WinApplication) || (this.Application is WebApplication))
            {
                ListView lv = this.View as ListView;
                var os = Application.CreateObjectSpace();
                var searchObj = os.CreateObject<StudentPersistent>();
                var View = Application.CreateDetailView(os, searchObj, true);
                View.ViewEditMode = ViewEditMode.Edit;
                e.View = View;
            }
        }

        /// <summary>
        /// 计划转订单
        /// </summary>
        private void plantomanubill_Execute(object sender, PopupWindowShowActionExecuteEventArgs e)
        {
            try
            {
                DetailView dv = e.PopupWindow.View as DetailView;
                if (dv != null)
                {
                    StudentPersistent sp = dv.CurrentObject as StudentPersistent;
                    if (sp != null)
                    {
                        IObjectSpace ios = Application.CreateObjectSpace();
                        ListView lvconvertbill = Application.CreateListView("Student_ListView_CheckBox",
                        new CollectionSource(ios, typeof(Student)), false);
                        e.ShowViewParameters.CreatedView = lvconvertbill;
                        e.ShowViewParameters.Context = TemplateContext.PopupWindow;
                        e.ShowViewParameters.TargetWindow = TargetWindow.NewModalWindow;
                        SaveAndCancelAction dc = new SaveAndCancelAction();
                        dc.btnconvertbillsave.Execute += Btnconvertbillsave_Execute;
                        dc.btnconvertbillcancel.Execute += Btnconvertbillcancel_Execute;
                        e.ShowViewParameters.Controllers.Add(dc);
                        dv.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                
            }
        }

        private void Btnconvertbillcancel_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
           
        }

        /// <summary>
        /// 计划转订单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btnconvertbillsave_Execute(object sender, SimpleActionExecuteEventArgs e)
        {
           
        }
        #endregion
    }
}

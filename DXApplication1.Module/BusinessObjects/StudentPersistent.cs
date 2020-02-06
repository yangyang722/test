using System;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;

namespace DXApplication1.Module.BusinessObjects
{
    [XafDisplayName("学生-查询")]
    [ImageName("BO_List")]
    [NonPersistent]
    public class StudentPersistent : XPLiteObject
    {
        public StudentPersistent() : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public StudentPersistent(Session session) : base(session)
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place here your initialization code.
        }

        [XafDisplayName("姓名")]
        public string Name { get; set; }
    }

}
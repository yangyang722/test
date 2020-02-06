using System;
using DevExpress.ExpressApp.DC;
using DevExpress.Persistent.Base;
using DevExpress.Xpo;

namespace DXApplication1.Module.BusinessObjects
{
    [XafDisplayName("学生")]
    [DefaultClassOptions]
    [ImageName("BO_List")]
    [Persistent("Student")]
    [XafDefaultProperty("Name")]
    public class Student : XPObject
    {
        public Student() : base()
        {
            // This constructor is used when an object is loaded from a persistent storage.
            // Do not place any code here.
        }

        public Student(Session session) : base(session)
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

        [XafDisplayName("年龄")]
        public int Age { get; set; }
    }

}
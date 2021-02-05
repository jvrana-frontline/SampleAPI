using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FluentValidation;

namespace FL.PG.PLM_EEM_API.ViewModels
{
    public class BuildingModel
    {
        public int Id { get; set; }
        public int DistrictID { get; set; }
        public string BuildingName { get; set; }
        public string BuildingType { get; set; }
        public string BuildingAddress2 { get; set; }
        public string BuildingAddress1 { get; set; }
        public string BuildingCity { get; set; }
        public string BuildingState { get; set; }
        public string BuildingZip { get; set; }
        public string BuildingContact { get; set; }
        public string BuildingPhone { get; set; }
        public int AdminID { get; set; }
        public int Order { get; set; }
        public int Admin2ID { get; set; }
        public string BuildingCode { get; set; }
        public int Admin3ID { get; set; }
        public bool Active { get; set; }
        public int Admin4ID { get; set; }
        public int Admin5ID { get; set; }
        public string BNCESID { get; set; }
        public int Admin6ID { get; set; }
        public int Admin7ID { get; set; }
        public int Admin8ID { get; set; }
        public int Admin9ID { get; set; }
        public bool IsExternal { get; set; }
        public string RemoteSysName { get; set; }
        public string RemoteSysID { get; set; }
    }

    public class BuildingModelValidator : AbstractValidator<BuildingModel>
    {
        public BuildingModelValidator()
        {
            RuleFor(x => x.Id).NotNull();
            RuleFor(x => x.DistrictID).NotNull();
            RuleFor(x => x.BuildingName).NotNull().Length(0, 50);
            RuleFor(x => x.BuildingType).NotNull().Length(0, 50);
            RuleFor(x => x.BuildingAddress2).NotNull().Length(0, 50);
            RuleFor(x => x.BuildingAddress1).NotNull().Length(0, 50);
            RuleFor(x => x.BuildingCity).NotNull().Length(0, 50);
            RuleFor(x => x.BuildingState).NotNull().Length(0, 2);
            RuleFor(x => x.BuildingZip).NotNull().Length(0, 50);
            RuleFor(x => x.BuildingContact).NotNull().Length(0, 50);
            RuleFor(x => x.BuildingPhone).NotNull().Length(0, 50);
            RuleFor(x => x.AdminID).NotNull();
            RuleFor(x => x.Order).NotNull();
            RuleFor(x => x.Admin2ID).NotNull();
            RuleFor(x => x.BuildingCode).NotNull().Length(0, 30);
            RuleFor(x => x.Admin3ID).NotNull();
            RuleFor(x => x.Active).NotNull();
            RuleFor(x => x.Admin4ID).NotNull();
            RuleFor(x => x.Admin5ID).NotNull();
            RuleFor(x => x.BNCESID).NotNull().Length(0, 20);
            RuleFor(x => x.Admin6ID).NotNull();
            RuleFor(x => x.Admin7ID).NotNull();
            RuleFor(x => x.Admin8ID).NotNull();
            RuleFor(x => x.Admin9ID).NotNull();
            RuleFor(x => x.IsExternal).NotNull();
            RuleFor(x => x.RemoteSysName).Null().Length(0, 50);
            RuleFor(x => x.RemoteSysID).Null().Length(0, 50);
        }
    }
}

using Application.DTOs.Base;

namespace Application.DTOs.Permission
{
    public class PermissionDto:BaseDto
    {
        public string ApiName { get; set; }
        public string Url { get; set; }
        public string AreaName { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public bool? NeedAccess { get; set; }
    }
}

using System.Collections.Generic;

namespace StarterKit.Blazor.WebAssembly.Shared.Models
{
    public class UserInfo
    {
        public bool IsAuthenticated { get; set; }
        public string UserName { get; set; }
        public Dictionary<string, string> ExposedClaims { get; set; }
    }
}

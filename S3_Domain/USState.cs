using Microsoft.EntityFrameworkCore;

namespace S3_Domain
{
    [PrimaryKey(nameof(StateId))]
    public class USState
    {
        public Guid StateId { get; set; } = Guid.NewGuid();

        public string StateCode { get; set; }

        public string StateName { get; set; }
    }
}

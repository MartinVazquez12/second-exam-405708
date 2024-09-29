using secondParcialWebAPI.Models;

namespace secondParcialWebAPI.DTOS
{
    public class SocioDtoId
    {
        public Guid socio_id { get; set; }
        public string soemail { get; set; } = null!;
        public string sonombre { get; set; } = null!;
        public string? sodni { get; set; }
    }
}

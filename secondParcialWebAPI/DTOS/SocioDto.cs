namespace secondParcialWebAPI.DTOS
{
    public class SocioDto
    {
        public Guid id_socio { get; set; }
        public string nombreso { get; set; } = null!;
        public string apellidoso { get; set; } = null!;
        public string dniso { get; set; } = null!;
        public Guid deporte_id { get; set; }
    }
}

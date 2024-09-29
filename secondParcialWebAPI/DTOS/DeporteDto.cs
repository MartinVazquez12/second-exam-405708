namespace secondParcialWebAPI.DTOS
{
    public class DeporteDto
    {
        public Guid Id { get; set; }

        public string nombreDeporte { get; set; } = null!;

        public string? Descripcion { get; set; }
    }
}

namespace SingleFamProperties.Dtos
{
    public class ValuationDto
    {
        public object AvmBpoValue { get; set; }
        public object AvmBpoAdjValue { get; set; }
        public object AvmBpoDate { get; set; }
        public float RsAvmValue { get; set; }
        public object RsAvmDate { get; set; }
        public float? RsBpoMergeValue { get; set; }
    }
}
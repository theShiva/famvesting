using System.Collections.Generic;

namespace SingleFamProperties.Dtos
{
    public class ResourcesDto
    {
        public List<PhotoDto> Photos { get; set; }
        public List<FloorPlanDto> FloorPlans { get; set; }
        public List<ThreeDRenderingDto> ThreeDRenderings { get; set; }
        public List<object> Audios { get; set; }
    }
}
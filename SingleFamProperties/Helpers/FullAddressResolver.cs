using System.Text;
using AutoMapper;
using SingleFamProperties.Dtos;

namespace SingleFamProperties.Helpers
{
    /// <summary>
    /// Resolves the address components of a property into a single full address string
    /// </summary>
    /// <remarks>Ref: See automapper documentation at https://github.com/AutoMapper/AutoMapper/wiki/Custom-value-resolvers
    /// </remarks>
    public class FullAddressResolver : IValueResolver<PropertyDto, PropertySummaryDto, string>
    {
        public string Resolve(PropertyDto source, PropertySummaryDto destination, string member, ResolutionContext context)
        {
            var addressBuilder = new StringBuilder();

            if (source.Address == null)
            {
                return null;
            }

            if (!string.IsNullOrEmpty(source.Address.Address1))
                addressBuilder.Append(source.Address.Address1);

            if (!string.IsNullOrEmpty(source.Address.Address2))
            {
                addressBuilder.Append(" ");
                addressBuilder.Append(source.Address.Address2);
            }

            if (!string.IsNullOrEmpty(source.Address.City))
            {
                addressBuilder.Append(", ");
                addressBuilder.Append(source.Address.City);
            }

            if (!string.IsNullOrEmpty(source.Address.State))
            {
                addressBuilder.Append(", ");
                addressBuilder.Append(source.Address.State);
            }

            if (!string.IsNullOrEmpty(source.Address.Zip))
            {
                addressBuilder.Append(" - ");
                addressBuilder.Append(source.Address.Zip);
            }

            if (!string.IsNullOrEmpty(source.Address.Country))
            {
                addressBuilder.Append(", ");
                addressBuilder.Append(source.Address.Country);
            }

            return addressBuilder.ToString();
        }
    }

}
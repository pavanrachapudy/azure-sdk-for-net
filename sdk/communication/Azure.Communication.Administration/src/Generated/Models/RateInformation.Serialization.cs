// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using Azure.Core;

namespace Azure.Communication.Administration.Models
{
    public partial class RateInformation
    {
        internal static RateInformation DeserializeRateInformation(JsonElement element)
        {
            Optional<double> monthlyRate = default;
            Optional<CurrencyType> currencyType = default;
            Optional<string> rateErrorMessage = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("monthlyRate"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    monthlyRate = property.Value.GetDouble();
                    continue;
                }
                if (property.NameEquals("currencyType"))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        property.ThrowNonNullablePropertyIsNull();
                        continue;
                    }
                    currencyType = new CurrencyType(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("rateErrorMessage"))
                {
                    rateErrorMessage = property.Value.GetString();
                    continue;
                }
            }
            return new RateInformation(Optional.ToNullable(monthlyRate), Optional.ToNullable(currencyType), rateErrorMessage.Value);
        }
    }
}

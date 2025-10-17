# Azure SDK Code Generation for Data Plane

Run `dotnet build /t:GenerateCode` to generate code.

### AutoRest Configuration
> see https://aka.ms/autorest

``` yaml
input-file:
- https://raw.githubusercontent.com/Azure/azure-rest-api-specs/8052426d23bf87cd8a3ad29a2fd5127e6054c434/specification/maps/data-plane/Route/stable/2025-01-01/route.json
title: RouteClient
openapi-type: data-plane
add-credentials: true
# at some point those credentials will move away to Swagger according to [this](https://github.com/Azure/autorest/issues/3718)
credential-default-policy-type: BearerTokenCredentialPolicy
credential-scopes: https://atlas.microsoft.com/.default
generation1-convenience-client: true
sync-methods: None
license-header: MICROSOFT_MIT_NO_VERSION
namespace: Azure.Maps.Routing
public-clients: false
clear-output-folder: true
data-plane: true
skip-csproj: true
helper-namespace: Azure.Maps.Common
```

```yaml
directive:
- from: swagger-document
  where: $.definitions.GeoJsonPoint
  transform: |
    $["x-ms-discriminator-value"] = $["Point"];
- from: swagger-document
  where: $.definitions.GeoJsonMultiPoint
  transform: |
    $["x-ms-discriminator-value"] = $["MultiPoint"];
- from: swagger-document
  where: $.definitions.GeoJsonMultiLineString
  transform: |
    $["x-ms-discriminator-value"] = $["MultiLineString"];
- from: swagger-document
  where: $.definitions.GeoJsonPolygon
  transform: |
    $["x-ms-discriminator-value"] = $["Polygon"];
- from: swagger-document
  where: $.definitions.AvoidEnum.items
  transform: |
    $["x-ms-enum"]["name"] = $["AvoidTypeEnum"];
- from: swagger-document
  where: $.definitions.RouteRangeAvoidEnum.items
  transform: |
    $["x-ms-enum"]["name"] = $["RouteRangeAvoidTypeEnum"];
- from: swagger-document
  where-model: $.definitions.InputRouteMatrixFeaturesItem.properties.properties
  remove-property: type
```

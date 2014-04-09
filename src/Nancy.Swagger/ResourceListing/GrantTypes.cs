using Nancy.Swagger.Attributes;
using Newtonsoft.Json;

namespace Nancy.Swagger.ResourceListing
{
    /// <summary>
    /// Provides details regarding the OAuth2 grant types that are supported by the API.
    /// </summary>
    /// <example>
    /// <code>
    /// {
    ///   "implicit": {
    ///     "loginEndpoint": {
    ///       "url": "http://petstore.swagger.wordnik.com/oauth/dialog"
    ///     },
    ///     "tokenName": "access_token"
    ///   },
    ///   "authorization_code": {
    ///     "tokenRequestEndpoint": {
    ///       "url": "http://petstore.swagger.wordnik.com/oauth/requestToken",
    ///       "clientIdName": "client_id",
    ///       "clientSecretName": "client_secret"
    ///     },
    ///     "tokenEndpoint": {
    ///       "url": "http://petstore.swagger.wordnik.com/oauth/token",
    ///       "tokenName": "access_code"
    ///     }
    ///   }
    /// }
    /// </code>
    /// </example>
    [SwaggerDto]
    public class GrantTypes
    {
        /// <summary>
        /// The Implicit Grant flow definition.
        /// </summary>
        [JsonProperty("implicit")]
        public ImplicitGrantFlow Implicit { get; set; }

        /// <summary>
        /// The Authorization Code Grant flow definition.
        /// </summary>
        [JsonProperty("authorization_code")]
        public AuthorizationCodeGrantFlow AuthorizationCode { get; set; }
    }
}
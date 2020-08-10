Blazor WebAssembly + OIDC POC
=============================

This project shows how to configure OIDC in a WASM SPA. 

This example includes:

* Configure OIDC (PKCE flow)
* Sign in and Sign out capabilities
* A `Profile` page where all the claims associated with the authenticated user are showed, and additionally the access token.

I followed the instructions provided by Microsoft [here](https://docs.microsoft.com/en-us/aspnet/core/blazor/security/webassembly/standalone-with-authentication-library?view=aspnetcore-3.1&tabs=visual-studio).
Tested successfully with Okta as the Idp.


## Prerequisites

Open the `BlazorAppWASM2.Client.Program` file and replace the `{issuer}` and `{clientId}` placeholders with your OIDC configuration.


##### Protocol negotiation With TLS
TLS not only for security. If Server endpoint endpoint supports multiple protocol, TLS will negotiate the connection protocol between the client and the server (Ex: HTTP/1.1 or HTTP/2).

If an HTTP/2 endpoint is configured without TLS, the endpoint's ListenOptions.Protocols must be set to HttpProtocols.Http2. An endpoint with multiple protocols  can't be used without TLS because there's no negotiation. Unsecured endpoint default to HTTP/1.1.

##### What is TLS
The Transport Layer Security protocol (TLS), defined by RFC 5246,
 is an evolution of the Secure Socket Layer protocol (SSL).[9] Both these protocols aim to provide a
  secure bidirectional connection between two communicating entities, usually called peers,
  with the following properties:

Test Case
---------

Demonstrates Xamarin Studio's Unit Test runner
failing to load tests due to Remoting error.
This occurs if a DLL uses Linq.Expression in
its function arguments.

Error Message
--------------

Sample traceback in "Test Results" window

	Internal error
	  RemotingException: Unix transport error
	  Stack Trace
	    at Mono.Remoting.Channels.Unix.UnixMessageIO...
	    at Mono.Remoting.Channels.Unix.UnixClientTransportSink...
	    at Systme.Runtime.Remoting.Channeels...


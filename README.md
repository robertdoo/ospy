# ospy
Automatically exported from code.google.com/p/ospy

What is it?

oSpy is a tool which aids in reverse-engineering software running on the Windows platform. With the amount of proprietary systems that exist today (synchronization protocols, instant messaging, etc.), the amount of work required to keep up when developing interoperable solutions will quickly become a big burden when limited to traditional techniques. However, when the sniffing is done on the API level it allows a much more fine-grained view of what's going on. Seeing return-addresses for each recv/send call (for example), can prove useful when you want to look at the processing code at that spot in a debugger or static analysis tool. And if an application uses encrypted communication it's easy to intercept these calls as well. oSpy already intercepts one such API, and is the API used by MSN Messenger, Google Talk, etc. for encrypting/decrypting HTTPS data. Another neat feature is when wanting to see how an application behaves when in a firewalled environment. Normally you would have to simulate such an environment by configuring firewalls etc., which not only is time-consuming, but might also cripple the rest of the applications you've got running. oSpy solves this problem by a feature called softwalling which allows you to set rules based on the type of function-call, the return-address, local/remote address/port, etc., and lets you choose which error to signal back to the application when the rule matches. This way you can make the application think that for example a connect() timed out, connection was refused, there was no route to host, etc.

Getting Involved

Want to help out? oSpy is an open source project and contributions are most appreciated! Whether you want to help out with artwork, code, documentation or anything else, don't hesitate to contact me at oleavr at gmail dot com. 

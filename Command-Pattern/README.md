# GoF Definition
Encapsulates a request as an object, thereby letting you parameterize clients with different requests, or log requests, and support undoable operations.

## Concept
This pattern encapsulates a method invocation process. An object can invoke an operation through some crystallized method and doesn't worry about how to perform the operation. 
Four terms are important here: *invoker, client, command,* and *receiver*
- The command object consists of the actions that a receiver performs.
- A *command* object can invoke a method of the receiver in a way that is specific to that receiver's class. The *receiver* then starts processing the job (or action)
- A command object is separately passed to the *invoker* object to invoke invoke the command. The invoker object contains the crystallized methods through which a client can perform a job without worrying how the target receiver performs the actual job.
- The *client* object holds the invoker object and the command objects. The client only makes the decition (i.e., which commands to execute) and then passes the command to the invokekr objectfor execution.

## Command Pattern UML
[Command Pattern UML class and sequence diagrm](https://upload.wikimedia.org/wikipedia/commons/c/c8/W3sDesign_Command_Design_Pattern_UML.jpg)

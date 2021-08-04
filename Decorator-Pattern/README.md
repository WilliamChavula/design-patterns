# GoF Definition

Attach additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality.

## Concept

This pattern uses and alternative to subclassing (i.e., inheritance). It prescribes you to use composition instead of inheritance.
By following the _SOLID_ principle, this pattern promotes the concept where your class is closed for modification but open for extension. Using this pattern, you can add special functionality to a specific object without altering the underlying class.
A decorator is just like a wrapper that surrounds the original object and adds additional functionality to it.
This pattern is most effective when you add decorators dynamically.

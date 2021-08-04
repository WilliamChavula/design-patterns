# GoF Definition

Define a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically.

## Concept

In this pattern, there are many observers (objects) that are observing a particular subject (also an object). Observers want to be notified when there is a change made inside the subject. So, they register for that subject. When they lose interest in the subject, they simply unregister from the subject.

Using this pattern, an object (subject) can send notifications to multiple observers (a set of objects) at the same time. Observers can decide how to respond to the notification, and they can perform specific actions based upon the notification.

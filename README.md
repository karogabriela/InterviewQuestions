# InterviewQuestions

This repository includes some common topics that are usually mentioned into technical interview questions.

There is a class for every single topic and for each class you will find an unit test class for testing all their methods.

## What is a unit test
It's a code written for testing a small piece of a whole program.

### The AAA pattern
It's a common way of writing unit tests for a method under test.

The Arrange section of a unit test method initializes objects and sets the value of the data that is passed to the method under test.

The Act section invokes the method under test with the arranged parameters.

The Assert section verifies that the action of the method under test behaves as expected. For .NET, methods in the Assert class are often used for verification.


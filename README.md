# Fluent Builder Example

Fluent Builder allows you to protect your unit tests from the signature change on your classes under test.
The fluent builder syntax is like this:


```
var sut = builder
  .WithName("SomeName")
  .WithDescription("SomeDescription)
  .Build();
```
If the signature of the class changes, you only need to update the builder class and not all the tests that references to the updated class.

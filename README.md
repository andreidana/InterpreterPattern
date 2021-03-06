# InterpreterPattern

**Definition** 

Given a language, define a represention for its grammar along with an interpreter that uses the representation to interpret sentences in the language. 

**Applicability**

Use the Interpreter pattern when there is a language to interpret, and you can represent statements in the language as abstract syntax trees. The Interpreter pattern works best when 

- the grammar is simple. For complex grammars, the class hierarchy for the grammar becomes large and unmanageable. Tools such as parser generators are a better alternative in such cases. They can interpret expressions without building abstract syntax trees, which can save space and possibly time.  
- efficiency is not a critical concern. The most efficient interpreters are usually not implemented by interpreting parse trees directly but by first translating them into another form. For example, regular expressions are often transformed into state machines. But even then, the translator can be implemented by the Interpreter pattern, so the pattern is still applicable. 

**Consequences**

- It's easy to change and extend the grammar.
- Implementing the grammar is easy, too.
- Complex grammars are hard to maintain.
- Adding new ways to interpret expressions.


**Related Patterns**

- [Composite](https://github.com/andreidana/CompositePattern)
- [Flyweight](https://github.com/andreidana/FlyweightExample)
- [Iterator](https://github.com/andreidana/IteratorPattern)
- [Visitor](https://github.com/andreidana/VisitorPattern)
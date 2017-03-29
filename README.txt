using Functional.Mathematic;

Using this library is not recommended, this is merely a playground space to standardize my knowledge on mathematics in high-leveled programming, and add some nice things that I think every basic mathematics library a language offers should have.

Hierarchy:
- Functional
  - Mathematic
    - Integer
	  + ToInteger()
	  + div()
	  + quot()
	  + mod()
	  + rem()
	  + divMod()
	  + quotRem()
	  + sqrt()
	- Floating Point
	  - Decimal
	    + mod()
	  - Double
	    + mod()
	  - Float
	    + mod()

Note:
Integer.ToInteger() is unfinished, see goals.
Floating Point is unfinished. Nothing is remotely close to what I have in mind.

Goals:
Respect Euclidean mod, the result of Euclidean mod, should always be positive. (The real reason I decided to create this.)
Automatic type promotion, pass two ints, and the result becomes a larger than int.MaxValue no worries, it gets promoted to Integer.BigNum.
Configurabilty, since accuracy is not quite the goal in most general computations done, be able to trade accuracy for speed, and vice versa. 
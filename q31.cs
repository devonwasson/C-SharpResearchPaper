/*

order of oepration for math operations ->

operations go from highest priority to lowest, and from left to right in
the event of two operations having the same priority.

Primary: x.y f{x} a[x] x++ x-- new typeof checked unchecked
Unary: + - ! ~ ++x --x (T)x
Multiplicative: * / %
Additive + -
shift: << >>
Relational and type testing: < > <= >= is as
Equality: == !=
Logical AND: &
Logical XOR: ^
Logical OR: |
Conditional AND: &&
Conditional OR: ||
Conditional: ?:
Assignment: = *= /= += -= <<= >>= &= ^= |=

source: https://msdn.microsoft.com/en-us/library/aa691323(v=vs.71).aspx

*/

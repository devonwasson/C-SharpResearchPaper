/*

If I could change one thing about c#, it would be the way it handles tuples.
After working with haskell, it would be much nicer if it handeled them that way.
In c#, one has to type Tuple<int, int> to define a tuple type and
Tuple.Create (x, y); to actually make it. If it worked like haskell, it could just be
(int, int) for our tuple type, and (x, y) to assign it.

for example, we could go from this to this:
Tuple<int, int> t = Tuple.Create(1,2);
(int, int) t = (1, 2);

*/

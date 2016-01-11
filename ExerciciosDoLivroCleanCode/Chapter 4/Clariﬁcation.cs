using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosDoLivroCleanCode.Chapter_4
{
    class Clariﬁcation
    {
        public void testCompareTo()
        {
            WikiPagePath a = PathParser.parse("PageA");
            WikiPagePath ab = PathParser.parse("PageA.PageB");
            WikiPagePath b = PathParser.parse("PageB");
            WikiPagePath aa = PathParser.parse("PageA.PageA");
            WikiPagePath bb = PathParser.parse("PageB.PageB");
            WikiPagePath ba = PathParser.parse("PageB.PageA");
            assertTrue(a.CompareTo(a) == 0);    // a == a
            assertTrue(a.CompareTo(b) != 0);    // a != b
            assertTrue(ab.CompareTo(ab) == 0);  // ab == ab
            assertTrue(a.CompareTo(b) == -1);   // a < b
            assertTrue(aa.CompareTo(ab) == -1); // aa < ab
            assertTrue(ba.CompareTo(bb) == -1); // ba < bb
            assertTrue(b.CompareTo(a) == 1);    // b > a
            assertTrue(ab.CompareTo(aa) == 1);  // ab > aa
            assertTrue(bb.CompareTo(ba) == 1);  // bb > ba
        }

        private void assertTrue(bool v)
        {
            throw new NotImplementedException();
        }
    }
}

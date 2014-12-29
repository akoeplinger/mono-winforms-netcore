using System;

namespace Accessibility
{
    public interface IAccessible
    {
        int accChildCount { get; }
        object accFocus { get; }
        object accParent { get; }
        object accSelection { get; }

        void accDoDefaultAction(object varChild);
        object accHitTest(int xLeft, int yTop);
        void accLocation(out int pxLeft, out int pyTop, out int pcxWidth, out int pcyHeight, object varChild);
        object accNavigate(int navDir, object varStart);
        void accSelect(int flagsSelect, object varChild);
        object get_accChild(object varChild);
        string get_accDefaultAction(object varChild);
        string get_accDescription(object varChild);
        string get_accHelp(object varChild);
        int get_accHelpTopic(out string pszHelpFile, object varChild);
        string get_accKeyboardShortcut(object varChild);
        string get_accName(object varChild);
        object get_accRole(object varChild);
        object get_accState(object varChild);
        string get_accValue(object varChild);
        void set_accName(object varChild, string pszName);
        void set_accValue(object varChild, string pszValue);
    }
}
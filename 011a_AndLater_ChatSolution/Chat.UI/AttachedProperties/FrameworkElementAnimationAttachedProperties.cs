using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learn.Wpf.AttachedProperties
{

    /// <summary>
    /// A base class 
    /// </summary>
    /// <typeparam name="TParent"></typeparam>
    public abstract class AnimateBaseProperty<TParent> : BaseAttachedProperty<TParent, bool> 
        where TParent: BaseAttachedProperty<TParent, bool>,new()
    {

    }
    public class FrameworkElementAnimationAttachedProperties
    {
    }
}

// Copyright (c) Xenko contributors (https://xenko.com) and Silicon Studio Corp. (https://www.siliconstudio.co.jp)
// Distributed under the MIT license. See the LICENSE.md file in the project root for more information.
using System;

namespace Xenko.Assets.Scripts
{
    /// <summary>
    /// Specifies that this field or property should be set if a compatible object is dropped on its containing <see cref="Block"/>.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field)]
    public class BlockDropTargetAttribute : Attribute
    {
    }
}

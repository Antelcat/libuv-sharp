﻿namespace Antelcat.LibuvSharp;

public interface IBindable<TType, TEndPoint>
{
    void Bind(TEndPoint endPoint);
}

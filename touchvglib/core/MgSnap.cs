/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace touchvg.core {

public class MgSnap : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal MgSnap(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(MgSnap obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~MgSnap() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          touchvgPINVOKE.delete_MgSnap(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public virtual void clearSnap(MgMotion sender) {
    touchvgPINVOKE.MgSnap_clearSnap(swigCPtr, MgMotion.getCPtr(sender));
  }

  public virtual bool drawSnap(MgMotion sender, GiGraphics gs) {
    bool ret = touchvgPINVOKE.MgSnap_drawSnap(swigCPtr, MgMotion.getCPtr(sender), GiGraphics.getCPtr(gs));
    return ret;
  }

  public virtual bool drawPerpMark(GiGraphics gs, GiContext ctx, Point2d a, Point2d b, Point2d perp, Point2d c, float len) {
    bool ret = touchvgPINVOKE.MgSnap_drawPerpMark(swigCPtr, GiGraphics.getCPtr(gs), GiContext.getCPtr(ctx), Point2d.getCPtr(a), Point2d.getCPtr(b), Point2d.getCPtr(perp), Point2d.getCPtr(c), len);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual int getSnappedType() {
    int ret = touchvgPINVOKE.MgSnap_getSnappedType(swigCPtr);
    return ret;
  }

  public virtual int getSnappedPoint(Point2d fromPt, Point2d toPt) {
    int ret = touchvgPINVOKE.MgSnap_getSnappedPoint__SWIG_0(swigCPtr, Point2d.getCPtr(fromPt), Point2d.getCPtr(toPt));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual int getSnappedPoint(Point2d fromPt, Point2d toPt, Point2d startPt, Point2d guildPt) {
    int ret = touchvgPINVOKE.MgSnap_getSnappedPoint__SWIG_1(swigCPtr, Point2d.getCPtr(fromPt), Point2d.getCPtr(toPt), Point2d.getCPtr(startPt), Point2d.getCPtr(guildPt));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public virtual void setIgnoreStartPoint(Point2d pt) {
    touchvgPINVOKE.MgSnap_setIgnoreStartPoint(swigCPtr, Point2d.getCPtr(pt));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual Point2d snapPoint(MgMotion sender, Point2d orignPt) {
    Point2d ret = new Point2d(touchvgPINVOKE.MgSnap_snapPoint(swigCPtr, MgMotion.getCPtr(sender), Point2d.getCPtr(orignPt)), true);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

}

}

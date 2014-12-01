/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace touchvg.core {

public class MgShapeDoc : MgObject {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal MgShapeDoc(global::System.IntPtr cPtr, bool cMemoryOwn) : base(touchvgPINVOKE.MgShapeDoc_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(MgShapeDoc obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          throw new global::System.MethodAccessException("C++ destructor does not have public access");
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public static int Type() {
    int ret = touchvgPINVOKE.MgShapeDoc_Type();
    return ret;
  }

  public MgShapeDoc cloneDoc() {
    global::System.IntPtr cPtr = touchvgPINVOKE.MgShapeDoc_cloneDoc(swigCPtr);
    MgShapeDoc ret = (cPtr == global::System.IntPtr.Zero) ? null : new MgShapeDoc(cPtr, false);
    return ret;
  }

  public MgShapeDoc shallowCopy() {
    global::System.IntPtr cPtr = touchvgPINVOKE.MgShapeDoc_shallowCopy(swigCPtr);
    MgShapeDoc ret = (cPtr == global::System.IntPtr.Zero) ? null : new MgShapeDoc(cPtr, false);
    return ret;
  }

  public int copyShapes(MgShapeDoc src, bool deeply) {
    int ret = touchvgPINVOKE.MgShapeDoc_copyShapes(swigCPtr, MgShapeDoc.getCPtr(src), deeply);
    return ret;
  }

  public static MgShapeDoc createDoc() {
    global::System.IntPtr cPtr = touchvgPINVOKE.MgShapeDoc_createDoc();
    MgShapeDoc ret = (cPtr == global::System.IntPtr.Zero) ? null : new MgShapeDoc(cPtr, false);
    return ret;
  }

  public bool save(MgStorage s, int startIndex) {
    bool ret = touchvgPINVOKE.MgShapeDoc_save(swigCPtr, MgStorage.getCPtr(s), startIndex);
    return ret;
  }

  public bool saveAll(MgStorage s, GiTransform xform) {
    bool ret = touchvgPINVOKE.MgShapeDoc_saveAll(swigCPtr, MgStorage.getCPtr(s), GiTransform.getCPtr(xform));
    return ret;
  }

  public bool load(MgShapeFactory factory, MgStorage s, bool addOnly) {
    bool ret = touchvgPINVOKE.MgShapeDoc_load(swigCPtr, MgShapeFactory.getCPtr(factory), MgStorage.getCPtr(s), addOnly);
    return ret;
  }

  public bool loadAll(MgShapeFactory factory, MgStorage s, GiTransform xform) {
    bool ret = touchvgPINVOKE.MgShapeDoc_loadAll(swigCPtr, MgShapeFactory.getCPtr(factory), MgStorage.getCPtr(s), GiTransform.getCPtr(xform));
    return ret;
  }

  public void clear() {
    touchvgPINVOKE.MgShapeDoc_clear(swigCPtr);
  }

  public void clearCachedData() {
    touchvgPINVOKE.MgShapeDoc_clearCachedData(swigCPtr);
  }

  public int draw(GiGraphics gs) {
    int ret = touchvgPINVOKE.MgShapeDoc_draw(swigCPtr, GiGraphics.getCPtr(gs));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int dyndraw(int mode, GiGraphics gs) {
    int ret = touchvgPINVOKE.MgShapeDoc_dyndraw(swigCPtr, mode, GiGraphics.getCPtr(gs));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Box2d getExtent() {
    Box2d ret = new Box2d(touchvgPINVOKE.MgShapeDoc_getExtent(swigCPtr), true);
    return ret;
  }

  public int getShapeCount() {
    int ret = touchvgPINVOKE.MgShapeDoc_getShapeCount(swigCPtr);
    return ret;
  }

  public MgShape findShape(int sid) {
    global::System.IntPtr cPtr = touchvgPINVOKE.MgShapeDoc_findShape(swigCPtr, sid);
    MgShape ret = (cPtr == global::System.IntPtr.Zero) ? null : new MgShape(cPtr, false);
    return ret;
  }

  public MgShape getLastShape() {
    global::System.IntPtr cPtr = touchvgPINVOKE.MgShapeDoc_getLastShape(swigCPtr);
    MgShape ret = (cPtr == global::System.IntPtr.Zero) ? null : new MgShape(cPtr, false);
    return ret;
  }

  public MgShapes getCurrentShapes() {
    global::System.IntPtr cPtr = touchvgPINVOKE.MgShapeDoc_getCurrentShapes(swigCPtr);
    MgShapes ret = (cPtr == global::System.IntPtr.Zero) ? null : new MgShapes(cPtr, false);
    return ret;
  }

  public bool setCurrentShapes(MgShapes shapes) {
    bool ret = touchvgPINVOKE.MgShapeDoc_setCurrentShapes(swigCPtr, MgShapes.getCPtr(shapes));
    return ret;
  }

  public MgLayer getCurrentLayer() {
    global::System.IntPtr cPtr = touchvgPINVOKE.MgShapeDoc_getCurrentLayer(swigCPtr);
    MgLayer ret = (cPtr == global::System.IntPtr.Zero) ? null : new MgLayer(cPtr, false);
    return ret;
  }

  public bool switchLayer(int index) {
    bool ret = touchvgPINVOKE.MgShapeDoc_switchLayer(swigCPtr, index);
    return ret;
  }

  public int getLayerCount() {
    int ret = touchvgPINVOKE.MgShapeDoc_getLayerCount(swigCPtr);
    return ret;
  }

  public GiContext context() {
    global::System.IntPtr cPtr = touchvgPINVOKE.MgShapeDoc_context(swigCPtr);
    GiContext ret = (cPtr == global::System.IntPtr.Zero) ? null : new GiContext(cPtr, false);
    return ret;
  }

  public Matrix2d modelTransform() {
    Matrix2d ret = new Matrix2d(touchvgPINVOKE.MgShapeDoc_modelTransform(swigCPtr), false);
    return ret;
  }

  public Box2d getPageRectW() {
    Box2d ret = new Box2d(touchvgPINVOKE.MgShapeDoc_getPageRectW(swigCPtr), false);
    return ret;
  }

  public float getViewScale() {
    float ret = touchvgPINVOKE.MgShapeDoc_getViewScale(swigCPtr);
    return ret;
  }

  public void setPageRectW(Box2d rectW, float viewScale, bool resetInitial) {
    touchvgPINVOKE.MgShapeDoc_setPageRectW__SWIG_0(swigCPtr, Box2d.getCPtr(rectW), viewScale, resetInitial);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public void setPageRectW(Box2d rectW, float viewScale) {
    touchvgPINVOKE.MgShapeDoc_setPageRectW__SWIG_1(swigCPtr, Box2d.getCPtr(rectW), viewScale);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool zoomToInitial(GiTransform xform) {
    bool ret = touchvgPINVOKE.MgShapeDoc_zoomToInitial(swigCPtr, GiTransform.getCPtr(xform));
    return ret;
  }

  public bool isReadOnly() {
    bool ret = touchvgPINVOKE.MgShapeDoc_isReadOnly(swigCPtr);
    return ret;
  }

  public void setReadOnly(bool readOnly) {
    touchvgPINVOKE.MgShapeDoc_setReadOnly(swigCPtr, readOnly);
  }

  public static MgShapeDoc fromHandle(int h) {
    global::System.IntPtr cPtr = touchvgPINVOKE.MgShapeDoc_fromHandle(h);
    MgShapeDoc ret = (cPtr == global::System.IntPtr.Zero) ? null : new MgShapeDoc(cPtr, false);
    return ret;
  }

  public int toHandle() {
    int ret = touchvgPINVOKE.MgShapeDoc_toHandle(swigCPtr);
    return ret;
  }

  public override MgObject clone() {
    global::System.IntPtr cPtr = touchvgPINVOKE.MgShapeDoc_clone(swigCPtr);
    MgObject ret = (cPtr == global::System.IntPtr.Zero) ? null : new MgObject(cPtr, false);
    return ret;
  }

  public override void copy(MgObject src) {
    touchvgPINVOKE.MgShapeDoc_copy(swigCPtr, MgObject.getCPtr(src));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void release() {
    touchvgPINVOKE.MgShapeDoc_release(swigCPtr);
  }

  public override void addRef() {
    touchvgPINVOKE.MgShapeDoc_addRef(swigCPtr);
  }

  public override bool equals(MgObject src) {
    bool ret = touchvgPINVOKE.MgShapeDoc_equals(swigCPtr, MgObject.getCPtr(src));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public override int getType() {
    int ret = touchvgPINVOKE.MgShapeDoc_getType(swigCPtr);
    return ret;
  }

  public override bool isKindOf(int type) {
    bool ret = touchvgPINVOKE.MgShapeDoc_isKindOf(swigCPtr, type);
    return ret;
  }

}

}

/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace touchvg.core {

public class MgCommandDraw : MgCommand {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal MgCommandDraw(global::System.IntPtr cPtr, bool cMemoryOwn) : base(touchvgPINVOKE.MgCommandDraw_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(MgCommandDraw obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~MgCommandDraw() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          touchvgPINVOKE.delete_MgCommandDraw(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public MgCommandDraw(string name) : this(touchvgPINVOKE.new_MgCommandDraw(name), true) {
    SwigDirectorConnect();
  }

  public MgShape addShape(MgMotion sender, MgShape shape) {
    global::System.IntPtr cPtr = touchvgPINVOKE.MgCommandDraw_addShape__SWIG_0(swigCPtr, MgMotion.getCPtr(sender), MgShape.getCPtr(shape));
    MgShape ret = (cPtr == global::System.IntPtr.Zero) ? null : new MgShape(cPtr, false);
    return ret;
  }

  public MgShape addShape(MgMotion sender) {
    global::System.IntPtr cPtr = touchvgPINVOKE.MgCommandDraw_addShape__SWIG_1(swigCPtr, MgMotion.getCPtr(sender));
    MgShape ret = (cPtr == global::System.IntPtr.Zero) ? null : new MgShape(cPtr, false);
    return ret;
  }

  public bool touchBeganStep(MgMotion sender) {
    bool ret = touchvgPINVOKE.MgCommandDraw_touchBeganStep(swigCPtr, MgMotion.getCPtr(sender));
    return ret;
  }

  public bool touchMovedStep(MgMotion sender) {
    bool ret = touchvgPINVOKE.MgCommandDraw_touchMovedStep(swigCPtr, MgMotion.getCPtr(sender));
    return ret;
  }

  public bool touchEndedStep(MgMotion sender) {
    bool ret = touchvgPINVOKE.MgCommandDraw_touchEndedStep(swigCPtr, MgMotion.getCPtr(sender));
    return ret;
  }

  public virtual int getShapeType() {
    int ret = (SwigDerivedClassHasMethod("getShapeType", swigMethodTypes17) ? touchvgPINVOKE.MgCommandDraw_getShapeTypeSwigExplicitMgCommandDraw(swigCPtr) : touchvgPINVOKE.MgCommandDraw_getShapeType(swigCPtr));
    return ret;
  }

  public void ignoreStartPoint(MgMotion sender, int handle) {
    touchvgPINVOKE.MgCommandDraw_ignoreStartPoint(swigCPtr, MgMotion.getCPtr(sender), handle);
  }

  public int getSnappedType(MgMotion sender) {
    int ret = touchvgPINVOKE.MgCommandDraw_getSnappedType(swigCPtr, MgMotion.getCPtr(sender));
    return ret;
  }

  public static Point2d getLastSnappedPoint() {
    Point2d ret = new Point2d(touchvgPINVOKE.MgCommandDraw_getLastSnappedPoint(), true);
    return ret;
  }

  public static Point2d getLastSnappedOriginPoint() {
    Point2d ret = new Point2d(touchvgPINVOKE.MgCommandDraw_getLastSnappedOriginPoint(), true);
    return ret;
  }

  protected virtual int getMaxStep() {
    int ret = (SwigDerivedClassHasMethod("getMaxStep", swigMethodTypes18) ? touchvgPINVOKE.MgCommandDraw_getMaxStepSwigExplicitMgCommandDraw(swigCPtr) : touchvgPINVOKE.MgCommandDraw_getMaxStep(swigCPtr));
    return ret;
  }

  protected virtual void setStepPoint(MgMotion sender, int step, Point2d pt) {
    if (SwigDerivedClassHasMethod("setStepPoint", swigMethodTypes19)) touchvgPINVOKE.MgCommandDraw_setStepPointSwigExplicitMgCommandDraw(swigCPtr, MgMotion.getCPtr(sender), step, Point2d.getCPtr(pt)); else touchvgPINVOKE.MgCommandDraw_setStepPoint(swigCPtr, MgMotion.getCPtr(sender), step, Point2d.getCPtr(pt));
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
  }

  public override bool initialize(MgMotion sender, MgStorage s) {
    bool ret = (SwigDerivedClassHasMethod("initialize", swigMethodTypes2) ? touchvgPINVOKE.MgCommandDraw_initializeSwigExplicitMgCommandDraw(swigCPtr, MgMotion.getCPtr(sender), MgStorage.getCPtr(s)) : touchvgPINVOKE.MgCommandDraw_initialize(swigCPtr, MgMotion.getCPtr(sender), MgStorage.getCPtr(s)));
    return ret;
  }

  public override bool backStep(MgMotion sender) {
    bool ret = (SwigDerivedClassHasMethod("backStep", swigMethodTypes3) ? touchvgPINVOKE.MgCommandDraw_backStepSwigExplicitMgCommandDraw(swigCPtr, MgMotion.getCPtr(sender)) : touchvgPINVOKE.MgCommandDraw_backStep(swigCPtr, MgMotion.getCPtr(sender)));
    return ret;
  }

  public override bool cancel(MgMotion sender) {
    bool ret = (SwigDerivedClassHasMethod("cancel", swigMethodTypes1) ? touchvgPINVOKE.MgCommandDraw_cancelSwigExplicitMgCommandDraw(swigCPtr, MgMotion.getCPtr(sender)) : touchvgPINVOKE.MgCommandDraw_cancel(swigCPtr, MgMotion.getCPtr(sender)));
    return ret;
  }

  public override bool draw(MgMotion sender, GiGraphics gs) {
    bool ret = (SwigDerivedClassHasMethod("draw", swigMethodTypes4) ? touchvgPINVOKE.MgCommandDraw_drawSwigExplicitMgCommandDraw(swigCPtr, MgMotion.getCPtr(sender), GiGraphics.getCPtr(gs)) : touchvgPINVOKE.MgCommandDraw_draw(swigCPtr, MgMotion.getCPtr(sender), GiGraphics.getCPtr(gs)));
    return ret;
  }

  public override bool gatherShapes(MgMotion sender, MgShapes shapes) {
    bool ret = (SwigDerivedClassHasMethod("gatherShapes", swigMethodTypes5) ? touchvgPINVOKE.MgCommandDraw_gatherShapesSwigExplicitMgCommandDraw(swigCPtr, MgMotion.getCPtr(sender), MgShapes.getCPtr(shapes)) : touchvgPINVOKE.MgCommandDraw_gatherShapes(swigCPtr, MgMotion.getCPtr(sender), MgShapes.getCPtr(shapes)));
    return ret;
  }

  public override bool touchBegan(MgMotion sender) {
    bool ret = (SwigDerivedClassHasMethod("touchBegan", swigMethodTypes9) ? touchvgPINVOKE.MgCommandDraw_touchBeganSwigExplicitMgCommandDraw(swigCPtr, MgMotion.getCPtr(sender)) : touchvgPINVOKE.MgCommandDraw_touchBegan(swigCPtr, MgMotion.getCPtr(sender)));
    return ret;
  }

  public override bool touchMoved(MgMotion sender) {
    bool ret = (SwigDerivedClassHasMethod("touchMoved", swigMethodTypes10) ? touchvgPINVOKE.MgCommandDraw_touchMovedSwigExplicitMgCommandDraw(swigCPtr, MgMotion.getCPtr(sender)) : touchvgPINVOKE.MgCommandDraw_touchMoved(swigCPtr, MgMotion.getCPtr(sender)));
    return ret;
  }

  public override bool touchEnded(MgMotion sender) {
    bool ret = (SwigDerivedClassHasMethod("touchEnded", swigMethodTypes11) ? touchvgPINVOKE.MgCommandDraw_touchEndedSwigExplicitMgCommandDraw(swigCPtr, MgMotion.getCPtr(sender)) : touchvgPINVOKE.MgCommandDraw_touchEnded(swigCPtr, MgMotion.getCPtr(sender)));
    return ret;
  }

  public override bool click(MgMotion sender) {
    bool ret = (SwigDerivedClassHasMethod("click", swigMethodTypes6) ? touchvgPINVOKE.MgCommandDraw_clickSwigExplicitMgCommandDraw(swigCPtr, MgMotion.getCPtr(sender)) : touchvgPINVOKE.MgCommandDraw_click(swigCPtr, MgMotion.getCPtr(sender)));
    return ret;
  }

  public override bool longPress(MgMotion sender) {
    bool ret = (SwigDerivedClassHasMethod("longPress", swigMethodTypes8) ? touchvgPINVOKE.MgCommandDraw_longPressSwigExplicitMgCommandDraw(swigCPtr, MgMotion.getCPtr(sender)) : touchvgPINVOKE.MgCommandDraw_longPress(swigCPtr, MgMotion.getCPtr(sender)));
    return ret;
  }

  public override bool mouseHover(MgMotion sender) {
    bool ret = (SwigDerivedClassHasMethod("mouseHover", swigMethodTypes12) ? touchvgPINVOKE.MgCommandDraw_mouseHoverSwigExplicitMgCommandDraw(swigCPtr, MgMotion.getCPtr(sender)) : touchvgPINVOKE.MgCommandDraw_mouseHover(swigCPtr, MgMotion.getCPtr(sender)));
    return ret;
  }

  public int getStep() {
    int ret = touchvgPINVOKE.MgCommandDraw_getStep(swigCPtr);
    return ret;
  }

  public MgShape dynshape() {
    global::System.IntPtr cPtr = touchvgPINVOKE.MgCommandDraw_dynshape(swigCPtr);
    MgShape ret = (cPtr == global::System.IntPtr.Zero) ? null : new MgShape(cPtr, false);
    return ret;
  }

  public void setStep(int step) {
    touchvgPINVOKE.MgCommandDraw_setStep(swigCPtr, step);
  }

  public Point2d snapPoint(MgMotion sender, bool firstStep) {
    Point2d ret = new Point2d(touchvgPINVOKE.MgCommandDraw_snapPoint__SWIG_0(swigCPtr, MgMotion.getCPtr(sender), firstStep), true);
    return ret;
  }

  public Point2d snapPoint(MgMotion sender) {
    Point2d ret = new Point2d(touchvgPINVOKE.MgCommandDraw_snapPoint__SWIG_1(swigCPtr, MgMotion.getCPtr(sender)), true);
    return ret;
  }

  public Point2d snapPoint(MgMotion sender, Point2d orignPt, bool firstStep) {
    Point2d ret = new Point2d(touchvgPINVOKE.MgCommandDraw_snapPoint__SWIG_2(swigCPtr, MgMotion.getCPtr(sender), Point2d.getCPtr(orignPt), firstStep), true);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Point2d snapPoint(MgMotion sender, Point2d orignPt) {
    Point2d ret = new Point2d(touchvgPINVOKE.MgCommandDraw_snapPoint__SWIG_3(swigCPtr, MgMotion.getCPtr(sender), Point2d.getCPtr(orignPt)), true);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Point2d snapPoint(MgMotion sender, Point2d orignPt, bool firstStep, int handle) {
    Point2d ret = new Point2d(touchvgPINVOKE.MgCommandDraw_snapPoint__SWIG_4(swigCPtr, MgMotion.getCPtr(sender), Point2d.getCPtr(orignPt), firstStep, handle), true);
    if (touchvgPINVOKE.SWIGPendingException.Pending) throw touchvgPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void SwigDirectorConnect() {
    if (SwigDerivedClassHasMethod("release", swigMethodTypes0))
      swigDelegate0 = new SwigDelegateMgCommandDraw_0(SwigDirectorrelease);
    if (SwigDerivedClassHasMethod("cancel", swigMethodTypes1))
      swigDelegate1 = new SwigDelegateMgCommandDraw_1(SwigDirectorcancel);
    if (SwigDerivedClassHasMethod("initialize", swigMethodTypes2))
      swigDelegate2 = new SwigDelegateMgCommandDraw_2(SwigDirectorinitialize);
    if (SwigDerivedClassHasMethod("backStep", swigMethodTypes3))
      swigDelegate3 = new SwigDelegateMgCommandDraw_3(SwigDirectorbackStep);
    if (SwigDerivedClassHasMethod("draw", swigMethodTypes4))
      swigDelegate4 = new SwigDelegateMgCommandDraw_4(SwigDirectordraw);
    if (SwigDerivedClassHasMethod("gatherShapes", swigMethodTypes5))
      swigDelegate5 = new SwigDelegateMgCommandDraw_5(SwigDirectorgatherShapes);
    if (SwigDerivedClassHasMethod("click", swigMethodTypes6))
      swigDelegate6 = new SwigDelegateMgCommandDraw_6(SwigDirectorclick);
    if (SwigDerivedClassHasMethod("doubleClick", swigMethodTypes7))
      swigDelegate7 = new SwigDelegateMgCommandDraw_7(SwigDirectordoubleClick);
    if (SwigDerivedClassHasMethod("longPress", swigMethodTypes8))
      swigDelegate8 = new SwigDelegateMgCommandDraw_8(SwigDirectorlongPress);
    if (SwigDerivedClassHasMethod("touchBegan", swigMethodTypes9))
      swigDelegate9 = new SwigDelegateMgCommandDraw_9(SwigDirectortouchBegan);
    if (SwigDerivedClassHasMethod("touchMoved", swigMethodTypes10))
      swigDelegate10 = new SwigDelegateMgCommandDraw_10(SwigDirectortouchMoved);
    if (SwigDerivedClassHasMethod("touchEnded", swigMethodTypes11))
      swigDelegate11 = new SwigDelegateMgCommandDraw_11(SwigDirectortouchEnded);
    if (SwigDerivedClassHasMethod("mouseHover", swigMethodTypes12))
      swigDelegate12 = new SwigDelegateMgCommandDraw_12(SwigDirectormouseHover);
    if (SwigDerivedClassHasMethod("twoFingersMove", swigMethodTypes13))
      swigDelegate13 = new SwigDelegateMgCommandDraw_13(SwigDirectortwoFingersMove);
    if (SwigDerivedClassHasMethod("isDrawingCommand", swigMethodTypes14))
      swigDelegate14 = new SwigDelegateMgCommandDraw_14(SwigDirectorisDrawingCommand);
    if (SwigDerivedClassHasMethod("isFloatingCommand", swigMethodTypes15))
      swigDelegate15 = new SwigDelegateMgCommandDraw_15(SwigDirectorisFloatingCommand);
    if (SwigDerivedClassHasMethod("doContextAction", swigMethodTypes16))
      swigDelegate16 = new SwigDelegateMgCommandDraw_16(SwigDirectordoContextAction);
    if (SwigDerivedClassHasMethod("getShapeType", swigMethodTypes17))
      swigDelegate17 = new SwigDelegateMgCommandDraw_17(SwigDirectorgetShapeType);
    if (SwigDerivedClassHasMethod("getMaxStep", swigMethodTypes18))
      swigDelegate18 = new SwigDelegateMgCommandDraw_18(SwigDirectorgetMaxStep);
    if (SwigDerivedClassHasMethod("setStepPoint", swigMethodTypes19))
      swigDelegate19 = new SwigDelegateMgCommandDraw_19(SwigDirectorsetStepPoint);
    touchvgPINVOKE.MgCommandDraw_director_connect(swigCPtr, swigDelegate0, swigDelegate1, swigDelegate2, swigDelegate3, swigDelegate4, swigDelegate5, swigDelegate6, swigDelegate7, swigDelegate8, swigDelegate9, swigDelegate10, swigDelegate11, swigDelegate12, swigDelegate13, swigDelegate14, swigDelegate15, swigDelegate16, swigDelegate17, swigDelegate18, swigDelegate19);
  }

  private bool SwigDerivedClassHasMethod(string methodName, global::System.Type[] methodTypes) {
    global::System.Reflection.MethodInfo methodInfo = this.GetType().GetMethod(methodName, global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic | global::System.Reflection.BindingFlags.Instance, null, methodTypes, null);
    bool hasDerivedMethod = methodInfo.DeclaringType.IsSubclassOf(typeof(MgCommandDraw));
    return hasDerivedMethod;
  }

  private void SwigDirectorrelease() {
    release();
  }

  private bool SwigDirectorcancel(global::System.IntPtr sender) {
    return cancel((sender == global::System.IntPtr.Zero) ? null : new MgMotion(sender, false));
  }

  private bool SwigDirectorinitialize(global::System.IntPtr sender, global::System.IntPtr s) {
    return initialize((sender == global::System.IntPtr.Zero) ? null : new MgMotion(sender, false), (s == global::System.IntPtr.Zero) ? null : new MgStorage(s, false));
  }

  private bool SwigDirectorbackStep(global::System.IntPtr sender) {
    return backStep((sender == global::System.IntPtr.Zero) ? null : new MgMotion(sender, false));
  }

  private bool SwigDirectordraw(global::System.IntPtr sender, global::System.IntPtr gs) {
    return draw((sender == global::System.IntPtr.Zero) ? null : new MgMotion(sender, false), (gs == global::System.IntPtr.Zero) ? null : new GiGraphics(gs, false));
  }

  private bool SwigDirectorgatherShapes(global::System.IntPtr sender, global::System.IntPtr shapes) {
    return gatherShapes((sender == global::System.IntPtr.Zero) ? null : new MgMotion(sender, false), (shapes == global::System.IntPtr.Zero) ? null : new MgShapes(shapes, false));
  }

  private bool SwigDirectorclick(global::System.IntPtr sender) {
    return click((sender == global::System.IntPtr.Zero) ? null : new MgMotion(sender, false));
  }

  private bool SwigDirectordoubleClick(global::System.IntPtr sender) {
    return doubleClick((sender == global::System.IntPtr.Zero) ? null : new MgMotion(sender, false));
  }

  private bool SwigDirectorlongPress(global::System.IntPtr sender) {
    return longPress((sender == global::System.IntPtr.Zero) ? null : new MgMotion(sender, false));
  }

  private bool SwigDirectortouchBegan(global::System.IntPtr sender) {
    return touchBegan((sender == global::System.IntPtr.Zero) ? null : new MgMotion(sender, false));
  }

  private bool SwigDirectortouchMoved(global::System.IntPtr sender) {
    return touchMoved((sender == global::System.IntPtr.Zero) ? null : new MgMotion(sender, false));
  }

  private bool SwigDirectortouchEnded(global::System.IntPtr sender) {
    return touchEnded((sender == global::System.IntPtr.Zero) ? null : new MgMotion(sender, false));
  }

  private bool SwigDirectormouseHover(global::System.IntPtr sender) {
    return mouseHover((sender == global::System.IntPtr.Zero) ? null : new MgMotion(sender, false));
  }

  private bool SwigDirectortwoFingersMove(global::System.IntPtr sender) {
    return twoFingersMove((sender == global::System.IntPtr.Zero) ? null : new MgMotion(sender, false));
  }

  private bool SwigDirectorisDrawingCommand() {
    return isDrawingCommand();
  }

  private bool SwigDirectorisFloatingCommand() {
    return isFloatingCommand();
  }

  private bool SwigDirectordoContextAction(global::System.IntPtr sender, int action) {
    return doContextAction((sender == global::System.IntPtr.Zero) ? null : new MgMotion(sender, false), action);
  }

  private int SwigDirectorgetShapeType() {
    return getShapeType();
  }

  private int SwigDirectorgetMaxStep() {
    return getMaxStep();
  }

  private void SwigDirectorsetStepPoint(global::System.IntPtr sender, int step, global::System.IntPtr pt) {
    setStepPoint((sender == global::System.IntPtr.Zero) ? null : new MgMotion(sender, false), step, new Point2d(pt, false));
  }

  public delegate void SwigDelegateMgCommandDraw_0();
  public delegate bool SwigDelegateMgCommandDraw_1(global::System.IntPtr sender);
  public delegate bool SwigDelegateMgCommandDraw_2(global::System.IntPtr sender, global::System.IntPtr s);
  public delegate bool SwigDelegateMgCommandDraw_3(global::System.IntPtr sender);
  public delegate bool SwigDelegateMgCommandDraw_4(global::System.IntPtr sender, global::System.IntPtr gs);
  public delegate bool SwigDelegateMgCommandDraw_5(global::System.IntPtr sender, global::System.IntPtr shapes);
  public delegate bool SwigDelegateMgCommandDraw_6(global::System.IntPtr sender);
  public delegate bool SwigDelegateMgCommandDraw_7(global::System.IntPtr sender);
  public delegate bool SwigDelegateMgCommandDraw_8(global::System.IntPtr sender);
  public delegate bool SwigDelegateMgCommandDraw_9(global::System.IntPtr sender);
  public delegate bool SwigDelegateMgCommandDraw_10(global::System.IntPtr sender);
  public delegate bool SwigDelegateMgCommandDraw_11(global::System.IntPtr sender);
  public delegate bool SwigDelegateMgCommandDraw_12(global::System.IntPtr sender);
  public delegate bool SwigDelegateMgCommandDraw_13(global::System.IntPtr sender);
  public delegate bool SwigDelegateMgCommandDraw_14();
  public delegate bool SwigDelegateMgCommandDraw_15();
  public delegate bool SwigDelegateMgCommandDraw_16(global::System.IntPtr sender, int action);
  public delegate int SwigDelegateMgCommandDraw_17();
  public delegate int SwigDelegateMgCommandDraw_18();
  public delegate void SwigDelegateMgCommandDraw_19(global::System.IntPtr sender, int step, global::System.IntPtr pt);

  private SwigDelegateMgCommandDraw_0 swigDelegate0;
  private SwigDelegateMgCommandDraw_1 swigDelegate1;
  private SwigDelegateMgCommandDraw_2 swigDelegate2;
  private SwigDelegateMgCommandDraw_3 swigDelegate3;
  private SwigDelegateMgCommandDraw_4 swigDelegate4;
  private SwigDelegateMgCommandDraw_5 swigDelegate5;
  private SwigDelegateMgCommandDraw_6 swigDelegate6;
  private SwigDelegateMgCommandDraw_7 swigDelegate7;
  private SwigDelegateMgCommandDraw_8 swigDelegate8;
  private SwigDelegateMgCommandDraw_9 swigDelegate9;
  private SwigDelegateMgCommandDraw_10 swigDelegate10;
  private SwigDelegateMgCommandDraw_11 swigDelegate11;
  private SwigDelegateMgCommandDraw_12 swigDelegate12;
  private SwigDelegateMgCommandDraw_13 swigDelegate13;
  private SwigDelegateMgCommandDraw_14 swigDelegate14;
  private SwigDelegateMgCommandDraw_15 swigDelegate15;
  private SwigDelegateMgCommandDraw_16 swigDelegate16;
  private SwigDelegateMgCommandDraw_17 swigDelegate17;
  private SwigDelegateMgCommandDraw_18 swigDelegate18;
  private SwigDelegateMgCommandDraw_19 swigDelegate19;

  private static global::System.Type[] swigMethodTypes0 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes1 = new global::System.Type[] { typeof(MgMotion) };
  private static global::System.Type[] swigMethodTypes2 = new global::System.Type[] { typeof(MgMotion), typeof(MgStorage) };
  private static global::System.Type[] swigMethodTypes3 = new global::System.Type[] { typeof(MgMotion) };
  private static global::System.Type[] swigMethodTypes4 = new global::System.Type[] { typeof(MgMotion), typeof(GiGraphics) };
  private static global::System.Type[] swigMethodTypes5 = new global::System.Type[] { typeof(MgMotion), typeof(MgShapes) };
  private static global::System.Type[] swigMethodTypes6 = new global::System.Type[] { typeof(MgMotion) };
  private static global::System.Type[] swigMethodTypes7 = new global::System.Type[] { typeof(MgMotion) };
  private static global::System.Type[] swigMethodTypes8 = new global::System.Type[] { typeof(MgMotion) };
  private static global::System.Type[] swigMethodTypes9 = new global::System.Type[] { typeof(MgMotion) };
  private static global::System.Type[] swigMethodTypes10 = new global::System.Type[] { typeof(MgMotion) };
  private static global::System.Type[] swigMethodTypes11 = new global::System.Type[] { typeof(MgMotion) };
  private static global::System.Type[] swigMethodTypes12 = new global::System.Type[] { typeof(MgMotion) };
  private static global::System.Type[] swigMethodTypes13 = new global::System.Type[] { typeof(MgMotion) };
  private static global::System.Type[] swigMethodTypes14 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes15 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes16 = new global::System.Type[] { typeof(MgMotion), typeof(int) };
  private static global::System.Type[] swigMethodTypes17 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes18 = new global::System.Type[] {  };
  private static global::System.Type[] swigMethodTypes19 = new global::System.Type[] { typeof(MgMotion), typeof(int), typeof(Point2d) };
}

}

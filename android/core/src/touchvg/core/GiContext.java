/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.11
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

package touchvg.core;

public class GiContext {
  private long swigCPtr;
  protected boolean swigCMemOwn;

  protected GiContext(long cPtr, boolean cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = cPtr;
  }

  protected static long getCPtr(GiContext obj) {
    return (obj == null) ? 0 : obj.swigCPtr;
  }

  protected void finalize() {
    delete();
  }

  public synchronized void delete() {
    if (swigCPtr != 0) {
      if (swigCMemOwn) {
        swigCMemOwn = false;
        touchvgJNI.delete_GiContext(swigCPtr);
      }
      swigCPtr = 0;
    }
  }

  public GiContext() {
    this(touchvgJNI.new_GiContext__SWIG_0(), true);
  }

  public GiContext(float width, GiColor color, int style, GiColor fillcr, boolean autoScale) {
    this(touchvgJNI.new_GiContext__SWIG_1(width, GiColor.getCPtr(color), color, style, GiColor.getCPtr(fillcr), fillcr, autoScale), true);
  }

  public GiContext(float width, GiColor color, int style, GiColor fillcr) {
    this(touchvgJNI.new_GiContext__SWIG_2(width, GiColor.getCPtr(color), color, style, GiColor.getCPtr(fillcr), fillcr), true);
  }

  public GiContext(float width, GiColor color, int style) {
    this(touchvgJNI.new_GiContext__SWIG_3(width, GiColor.getCPtr(color), color, style), true);
  }

  public GiContext(float width, GiColor color) {
    this(touchvgJNI.new_GiContext__SWIG_4(width, GiColor.getCPtr(color), color), true);
  }

  public GiContext(float width) {
    this(touchvgJNI.new_GiContext__SWIG_5(width), true);
  }

  public GiContext(GiContext src) {
    this(touchvgJNI.new_GiContext__SWIG_6(GiContext.getCPtr(src), src), true);
  }

  public GiContext copy(GiContext src, int mask) {
    return new GiContext(touchvgJNI.GiContext_copy__SWIG_0(swigCPtr, this, GiContext.getCPtr(src), src, mask), false);
  }

  public GiContext copy(GiContext src) {
    return new GiContext(touchvgJNI.GiContext_copy__SWIG_1(swigCPtr, this, GiContext.getCPtr(src), src), false);
  }

  public boolean equals(GiContext src) {
    return touchvgJNI.GiContext_equals(swigCPtr, this, GiContext.getCPtr(src), src);
  }

  public int getLineStyle() {
    return touchvgJNI.GiContext_getLineStyle(swigCPtr, this);
  }

  public void setLineStyle(int style) {
    touchvgJNI.GiContext_setLineStyle(swigCPtr, this, style);
  }

  public float getLineWidth() {
    return touchvgJNI.GiContext_getLineWidth(swigCPtr, this);
  }

  public boolean isAutoScale() {
    return touchvgJNI.GiContext_isAutoScale(swigCPtr, this);
  }

  public void setLineWidth(float width, boolean autoScale) {
    touchvgJNI.GiContext_setLineWidth(swigCPtr, this, width, autoScale);
  }

  public boolean isNullLine() {
    return touchvgJNI.GiContext_isNullLine(swigCPtr, this);
  }

  public void setNullLine() {
    touchvgJNI.GiContext_setNullLine(swigCPtr, this);
  }

  public GiColor getLineColor() {
    return new GiColor(touchvgJNI.GiContext_getLineColor(swigCPtr, this), true);
  }

  public void setLineColor(GiColor color) {
    touchvgJNI.GiContext_setLineColor__SWIG_0(swigCPtr, this, GiColor.getCPtr(color), color);
  }

  public void setLineColor(int r, int g, int b) {
    touchvgJNI.GiContext_setLineColor__SWIG_1(swigCPtr, this, r, g, b);
  }

  public void setLineColor(int r, int g, int b, int a) {
    touchvgJNI.GiContext_setLineColor__SWIG_2(swigCPtr, this, r, g, b, a);
  }

  public int getLineARGB() {
    return touchvgJNI.GiContext_getLineARGB(swigCPtr, this);
  }

  public void setLineARGB(int argb) {
    touchvgJNI.GiContext_setLineARGB(swigCPtr, this, argb);
  }

  public int getLineAlpha() {
    return touchvgJNI.GiContext_getLineAlpha(swigCPtr, this);
  }

  public void setLineAlpha(int alpha) {
    touchvgJNI.GiContext_setLineAlpha(swigCPtr, this, alpha);
  }

  public boolean hasFillColor() {
    return touchvgJNI.GiContext_hasFillColor(swigCPtr, this);
  }

  public void setNoFillColor() {
    touchvgJNI.GiContext_setNoFillColor(swigCPtr, this);
  }

  public GiColor getFillColor() {
    return new GiColor(touchvgJNI.GiContext_getFillColor(swigCPtr, this), true);
  }

  public void setFillColor(GiColor color) {
    touchvgJNI.GiContext_setFillColor__SWIG_0(swigCPtr, this, GiColor.getCPtr(color), color);
  }

  public void setFillColor(int r, int g, int b) {
    touchvgJNI.GiContext_setFillColor__SWIG_1(swigCPtr, this, r, g, b);
  }

  public void setFillColor(int r, int g, int b, int a) {
    touchvgJNI.GiContext_setFillColor__SWIG_2(swigCPtr, this, r, g, b, a);
  }

  public int getFillARGB() {
    return touchvgJNI.GiContext_getFillARGB(swigCPtr, this);
  }

  public void setFillARGB(int argb) {
    touchvgJNI.GiContext_setFillARGB(swigCPtr, this, argb);
  }

  public int getFillAlpha() {
    return touchvgJNI.GiContext_getFillAlpha(swigCPtr, this);
  }

  public void setFillAlpha(int alpha) {
    touchvgJNI.GiContext_setFillAlpha(swigCPtr, this, alpha);
  }

  public boolean isAutoFillColor() {
    return touchvgJNI.GiContext_isAutoFillColor(swigCPtr, this);
  }

  public void setAutoFillColor(boolean value) {
    touchvgJNI.GiContext_setAutoFillColor(swigCPtr, this, value);
  }

  public int getType() {
    return touchvgJNI.GiContext_getType(swigCPtr, this);
  }

}

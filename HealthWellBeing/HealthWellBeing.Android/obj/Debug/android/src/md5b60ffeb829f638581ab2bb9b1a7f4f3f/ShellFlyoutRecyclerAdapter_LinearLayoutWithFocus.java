package md5b60ffeb829f638581ab2bb9b1a7f4f3f;


public class ShellFlyoutRecyclerAdapter_LinearLayoutWithFocus
	extends android.widget.LinearLayout
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_focusSearch:(I)Landroid/view/View;:GetFocusSearch_IHandler\n" +
			"";
		mono.android.Runtime.register ("Xamarin.Forms.Platform.Android.ShellFlyoutRecyclerAdapter+LinearLayoutWithFocus, Xamarin.Forms.Platform.Android, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null", ShellFlyoutRecyclerAdapter_LinearLayoutWithFocus.class, __md_methods);
	}


	public ShellFlyoutRecyclerAdapter_LinearLayoutWithFocus (android.content.Context p0)
	{
		super (p0);
		if (getClass () == ShellFlyoutRecyclerAdapter_LinearLayoutWithFocus.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.Platform.Android.ShellFlyoutRecyclerAdapter+LinearLayoutWithFocus, Xamarin.Forms.Platform.Android, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public ShellFlyoutRecyclerAdapter_LinearLayoutWithFocus (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == ShellFlyoutRecyclerAdapter_LinearLayoutWithFocus.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.Platform.Android.ShellFlyoutRecyclerAdapter+LinearLayoutWithFocus, Xamarin.Forms.Platform.Android, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0, p1 });
	}


	public ShellFlyoutRecyclerAdapter_LinearLayoutWithFocus (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == ShellFlyoutRecyclerAdapter_LinearLayoutWithFocus.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.Platform.Android.ShellFlyoutRecyclerAdapter+LinearLayoutWithFocus, Xamarin.Forms.Platform.Android, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public ShellFlyoutRecyclerAdapter_LinearLayoutWithFocus (android.content.Context p0, android.util.AttributeSet p1, int p2, int p3)
	{
		super (p0, p1, p2, p3);
		if (getClass () == ShellFlyoutRecyclerAdapter_LinearLayoutWithFocus.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.Platform.Android.ShellFlyoutRecyclerAdapter+LinearLayoutWithFocus, Xamarin.Forms.Platform.Android, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1, p2, p3 });
	}


	public android.view.View focusSearch (int p0)
	{
		return n_focusSearch (p0);
	}

	private native android.view.View n_focusSearch (int p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}

package md5b60ffeb829f638581ab2bb9b1a7f4f3f;


public abstract class NongreedySnapHelper
	extends android.support.v7.widget.LinearSnapHelper
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_attachToRecyclerView:(Landroid/support/v7/widget/RecyclerView;)V:GetAttachToRecyclerView_Landroid_support_v7_widget_RecyclerView_Handler\n" +
			"";
		mono.android.Runtime.register ("Xamarin.Forms.Platform.Android.NongreedySnapHelper, Xamarin.Forms.Platform.Android, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null", NongreedySnapHelper.class, __md_methods);
	}


	public NongreedySnapHelper ()
	{
		super ();
		if (getClass () == NongreedySnapHelper.class)
			mono.android.TypeManager.Activate ("Xamarin.Forms.Platform.Android.NongreedySnapHelper, Xamarin.Forms.Platform.Android, Version=2.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void attachToRecyclerView (android.support.v7.widget.RecyclerView p0)
	{
		n_attachToRecyclerView (p0);
	}

	private native void n_attachToRecyclerView (android.support.v7.widget.RecyclerView p0);

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

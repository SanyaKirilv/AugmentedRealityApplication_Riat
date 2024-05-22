using System;
using System.Collections;
using UnityEngine;

public class PictureManager : MonoBehaviour {
    public void MakePhoto() => StartCoroutine(TakePicture());

    IEnumerator TakePicture() {
        yield return new WaitForEndOfFrame();
        Camera camera = Camera.main;
        int width = Screen.width;
        int height = Screen.height;
        RenderTexture rt = new(width, height, 24);
        camera.targetTexture = rt;

        var currentRT = RenderTexture.active;
        RenderTexture.active = rt;

        camera.Render();

        Texture2D image = new Texture2D(width, height);
        image.ReadPixels(new Rect(0, 0, width, height), 0, 0);
        image.Apply();

        camera.targetTexture = null;
        RenderTexture.active = currentRT;

        byte[] bytes = image.EncodeToPNG();
        string fileName = DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".png";
        NativeGallery.SaveImageToGallery(image,"Recent", fileName);
        
        Destroy(rt);
        Destroy(image);
    }
}

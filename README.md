# DroidBinding_StepsView
anton46/Android-StepsView 组件的Xamarin.Android的绑定。

# Android-StepsView

![Example image](./image1.png) ![Example image](./image2.png)

## Usage

```xml
 <com.anton46.stepsview.StepsView
        xmlns:app="http://schemas.android.com/apk/res-auto"
        android:id="@+id/stepsView"
        android:layout_width="match_parent"
        android:layout_height="wrap_content"
        />
```

```C#
stepsView.SetLabels(steps)
         .SetBarColorIndicator(ContextCompat.GetColor(this, Resource.Color.material_blue_grey_800))
         .SetProgressColorIndicator(ContextCompat.GetColor(this, Resource.Color.orange))
         .SetLabelColorIndicator(ContextCompat.GetColor(this, Resource.Color.orange))
         .SetCompletedPosition(0)
         .DrawView();
```

Android-StepsView Developed by
========================
* Anton Nurdin Tuhadiansyah (anton.work19@gmail.com)
* [anton46.com][1]

[1]: http://anton46.com

License
-----------

```
Copyright 2015 Anton Nurdin Tuhadiansyah

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

   http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
```
/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 * Copyright (c) 2015 Keno Schwalb
 */

using UnityEngine;

public class ImageAnalysisOptionsHandler : MonoBehaviour
{
	public void FullScaleImageButtonClicked () {
		CameraView.scaleImage = false;
	}

	public void ScaledImageButtonClicked () {
		CameraView.scaleImage = true;
	}

	public void CalibrateButtonClicked () {
		CameraView.startCalibration = true;
	}
}

void Update()
{
if (Input.GetButtonDown("StartDance")) // Start or pause the dance animation
{
if (!isDancing)
{
animator.SetTrigger("StartDance");
isDancing = true;
}
else
{
animator.ResetTrigger("StartDance");
isDancing = false;
}
}
if (Input.GetButtonDown("ChangeDanceStyle")) // Switch to a different dance
style
{
animator.SetTrigger("ChangeDanceStyle");
}
}

void BlendAnimations()
{
float blendFactor = Mathf.Clamp01(speed * 0.1f); // Adjust animation speed
animator.SetFloat("BlendFactor", blendFactor); // Apply blending factor
// Update animation states
animator.SetBool("IsDancing", isDancing);
animator.SetBool("IsIdle", !isDancing);
}

void SaveUserPreferences()
{
PlayerPrefs.SetFloat("AnimationSpeed", speed);
PlayerPrefs.SetString("CurrentDanceStyle", currentDanceStyle);
}
9
void LoadUserPreferences()
{
speed = PlayerPrefs.GetFloat("AnimationSpeed");
currentDanceStyle = PlayerPrefs.GetString("CurrentDanceStyle");
}


#version 330 core

in vec3 FragPosition;

out vec4 FragColor;

void main() {
    float r = abs(cos(FragPosition.x));
    float g = abs(sin(FragPosition.y));
    FragColor = vec4(r, g, 0.0, 1.0);
}

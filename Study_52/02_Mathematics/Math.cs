namespace Study_52
{
    /// <summary>
    /// Math 클래스 모방
    /// </summary>
    public class Math
    {
        /// <summary>
        /// 절대값 구하기
        /// </summary>
        /// <param name="number">자연수</param>
        /// <returns>절대값</returns>
        public static int Abs(int number) => (number < 0) ? -number : number;
    }
}

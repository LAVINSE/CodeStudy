using System;
using System.Security;

namespace StudyLinkedList
{

    // 32:29
    public class Program
    {
        private static void Main(string[] args)
        {

        }
    }

    /** 연결 리스트 */
    public class LinkedList<T>
    {
        /** 노드 */
        public class Node
        {
            public T Value; // 값

            public Node PrevNode; // 이전 노드
            public Node NextNode; // 다음 노드
        }

        #region 변수
        private Node HeadNode = null; // 첫번째 노드
        private int NumVals = 0; // 데이터 개수
        #endregion // 변수

        #region 프로퍼티
        public int Count => NumVals;
        #endregion // 프로퍼티

        #region 함수
        /** 값을 추가한다 */
        public void Add(T Value)
        {

        }

        /** 원하는 위치에 값을 추가한다 */
        public void Insert(int Index, T Value)
        {

        }

        /** 가장 먼저 있는 값을 제거한다 */
        public void Remove(T Value)
        {

        }
        /** 원하는 위치의 값을 제거한다 */
        public void RemoveAt(int Index)
        {

        }
        #endregion // 함수

        #region 접근 함수
        /** 값을 탐색한다 */
        public int Find(T Value)
        {
            int Idx = 0;
            var CurrentNode = HeadNode;

            while(CurrentNode != null)
            {
                // 값이 존재 할 경우
                if(CurrentNode.Value.Equals(Value))
                {
                    return Idx;
                }

                // 값이 존재하지 않을 경우
                Idx += 1; // 인덱스 증가
                CurrentNode = CurrentNode.NextNode; // 다음 노드 탐색
            }

            return -1; // 값이 없을 경우 -1
        }
        
        /** 인덱스 유효 여부를 검사한다 */
        public bool IsValidIndex(int Index)
        {
            return Index >= 0 && Index < NumVals;
        }
        #endregion // 접근 함수
    }
}